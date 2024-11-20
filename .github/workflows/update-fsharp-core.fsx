// This script will update all  .fsproj  files in the repository to the latest version of FSharp.Core.
// to address https://github.com/dependabot/dependabot-core/issues/10883

open System
open System.IO
open System.Net.Http
open System.Text.Json
let updateFsprojFiles() =

    let tryBetween (firstSplitter:string) (secondSplitter:string) (stringToSplit:string): option<string>  =
        let start = stringToSplit.IndexOf(firstSplitter, StringComparison.Ordinal)
        if start = -1 then None
        else
            let ende = stringToSplit.IndexOf(secondSplitter, start + firstSplitter.Length, StringComparison.Ordinal)
            if ende = -1 then None
            else
                Some <| stringToSplit.Substring(start + firstSplitter.Length, ende - start - firstSplitter.Length)

    let getLatestFSharpCoreVersion() =
        task {
            use client = new HttpClient()
            let! response = client.GetStringAsync("https://api.nuget.org/v3-flatcontainer/fsharp.core/index.json")
            return
                    JsonDocument
                        .Parse(response)
                        .RootElement
                        .GetProperty("versions")
                        .EnumerateArray()
                    |> Seq.map (fun v -> v.GetString())
                    |> Seq.filter (fun v -> not (v.Contains("-"))) // exclude pre-release versions
                    |> Seq.max
        }

    let extractVersion (line: string) =
        if line.Contains("<PackageReference") && line.Contains "Update=\"FSharp.Core\"" then
            tryBetween "Version=\""  "\""  line
            |> Option.map (fun v -> v.Trim())
        else
            None

    let newVersion = getLatestFSharpCoreVersion().Result
    let root =  DirectoryInfo(__SOURCE_DIRECTORY__).Parent.Parent
    let fsprojFiles = Directory.GetFiles(root.FullName, "*.fsproj", SearchOption.AllDirectories)
    let mutable msg = ""
    for file in fsprojFiles do
        printfn "Processing %s" file
        let lns = File.ReadAllLines(file)
        let mutable fixedFile = false
        for i,ln in Seq.indexed lns do
            match extractVersion ln with
            | Some(v) ->
                if v <> newVersion then
                    let newLine = ln.Replace($"Version=\"{v}\"", $"Version=\"{newVersion}\"")
                    lns.[i] <- newLine
                    fixedFile <- true
                    let info = $" - FSharp.Core.{v} -> {newVersion}"
                    printfn "%s" info
                    if msg = "" then
                        msg <-  info
                    else
                        msg <- $"{msg}{Environment.NewLine}{info}"
                else
                    printfn $" - FSharp.Core is already up to date"

            | None -> ()
        if fixedFile then
            File.WriteAllLines(file, lns, Text.Encoding.UTF8)


    // Print variables to console
    printfn $"::set-output name=fsharpCoreNewVersion::{newVersion}"
    printfn $"::set-output name=fsharpCoreUpdatedFiles::{msg}"

    // if msg <> "" then
    //     IO.File.WriteAllText("./.github/workflows/update-fsharp-core.log", msg)
    //     printfn "Updated the following files:"
    //     printfn "%s" msg
    // else
    //     printfn "No files were updated"




updateFsprojFiles()
