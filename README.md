# DependabotTest

To demonstrate that dependabot is not able to update FSharp.Core

see https://github.com/dependabot/dependabot-core/issues/10883

## Log

```log
2024-11-19T22:24:55.6209498Z Dependabot encountered '1' error(s) during execution, please check the logs for more details.
2024-11-19T22:24:55.6211104Z +-----------------------------------+
2024-11-19T22:24:55.6212018Z |   Dependencies failed to update   |
2024-11-19T22:24:55.6212826Z +-------------+---------------------+
2024-11-19T22:24:55.6213631Z | FSharp.Core | update_not_possible |
2024-11-19T22:24:55.6214589Z +-------------+---------------------+
```

Full log:

```log
2024-11-19T22:24:00.8312105Z Current runner version: '2.320.0'
2024-11-19T22:24:00.8336987Z ##[group]Operating System
2024-11-19T22:24:00.8337703Z Ubuntu
2024-11-19T22:24:00.8338045Z 22.04.5
2024-11-19T22:24:00.8338389Z LTS
2024-11-19T22:24:00.8338804Z ##[endgroup]
2024-11-19T22:24:00.8339207Z ##[group]Runner Image
2024-11-19T22:24:00.8339635Z Image: ubuntu-22.04
2024-11-19T22:24:00.8340118Z Version: 20241112.1.0
2024-11-19T22:24:00.8341150Z Included Software: https://github.com/actions/runner-images/blob/ubuntu22/20241112.1/images/ubuntu/Ubuntu2204-Readme.md
2024-11-19T22:24:00.8342603Z Image Release: https://github.com/actions/runner-images/releases/tag/ubuntu22%2F20241112.1
2024-11-19T22:24:00.8343538Z ##[endgroup]
2024-11-19T22:24:00.8343958Z ##[group]Runner Image Provisioner
2024-11-19T22:24:00.8344412Z 2.0.384.1
2024-11-19T22:24:00.8344844Z ##[endgroup]
2024-11-19T22:24:00.8359708Z ##[group]GITHUB_TOKEN Permissions
2024-11-19T22:24:00.8361319Z Contents: read
2024-11-19T22:24:00.8361865Z Metadata: read
2024-11-19T22:24:00.8362427Z Packages: read
2024-11-19T22:24:00.8362999Z ##[endgroup]
2024-11-19T22:24:00.8366015Z Secret source: None
2024-11-19T22:24:00.8366544Z Prepare workflow directory
2024-11-19T22:24:00.8991848Z Prepare all required actions
2024-11-19T22:24:00.9155894Z Getting action download info
2024-11-19T22:24:01.1648574Z Download action repository 'github/dependabot-action@main' (SHA:593fbfbc54c854524bf466c5a78effae9f8a692a)
2024-11-19T22:24:01.9080929Z Complete job name: Dependabot
2024-11-19T22:24:02.0026787Z ##[group]Run mkdir -p  ./dependabot-job-919589018-1732055027
2024-11-19T22:24:02.0027778Z [36;1mmkdir -p  ./dependabot-job-919589018-1732055027[0m
2024-11-19T22:24:02.0135457Z shell: /usr/bin/bash -e {0}
2024-11-19T22:24:02.0136029Z ##[endgroup]
2024-11-19T22:24:02.0784658Z ##[group]Run github/dependabot-action@main
2024-11-19T22:24:02.0785411Z env:
2024-11-19T22:24:02.0785814Z   DEPENDABOT_DISABLE_CLEANUP: 1
2024-11-19T22:24:02.0786382Z   DEPENDABOT_ENABLE_CONNECTIVITY_CHECK: 0
2024-11-19T22:24:02.0787289Z   GITHUB_TOKEN: ***
2024-11-19T22:24:02.0788209Z   GITHUB_DEPENDABOT_JOB_TOKEN: ***
2024-11-19T22:24:02.0789263Z   GITHUB_DEPENDABOT_CRED_TOKEN: ***
2024-11-19T22:24:02.0789787Z ##[endgroup]
2024-11-19T22:24:02.3290243Z 🤖 ~ starting update ~
2024-11-19T22:24:02.3335336Z Fetching job details
2024-11-19T22:24:02.9385937Z ##[group]Pulling updater images
2024-11-19T22:24:02.9434655Z Pulling image ghcr.io/dependabot/dependabot-updater-nuget:5c6c676dd9a1055774bc95c4a4d2f38513f1ac50...
2024-11-19T22:24:37.9731584Z Pulled image ghcr.io/dependabot/dependabot-updater-nuget:5c6c676dd9a1055774bc95c4a4d2f38513f1ac50
2024-11-19T22:24:37.9745317Z Pulling image ghcr.io/github/dependabot-update-job-proxy/dependabot-update-job-proxy:v2.0.20241004183849@sha256:5e895b5edfaba72e99d0a19b43f386b18b65fc08a2d43af5aedd6360cda56842...
2024-11-19T22:24:38.9093736Z Pulled image ghcr.io/github/dependabot-update-job-proxy/dependabot-update-job-proxy:v2.0.20241004183849@sha256:5e895b5edfaba72e99d0a19b43f386b18b65fc08a2d43af5aedd6360cda56842
2024-11-19T22:24:38.9096016Z ##[endgroup]
2024-11-19T22:24:38.9096875Z Starting update process
2024-11-19T22:24:39.2438831Z Created proxy container: c805beb3686e44391017775ad283504570fc3d045530d4fbdfdf7d8ae7112254
2024-11-19T22:24:39.6055076Z Created container: 6356a4c35319383f3c9b96b9eeb64b6bd508aae93f37acdb9ab6ff5a6403fdf5
2024-11-19T22:24:39.6213987Z   proxy | 2024/11/19 22:24:39 proxy starting, commit: 4ff727a3a0f3cf493d1700d4ceec3c6f880b430e
2024-11-19T22:24:39.6219888Z   proxy | 2024/11/19 22:24:39 Listening (:1080)
2024-11-19T22:24:39.8090151Z updater | Updating certificates in /etc/ssl/certs...
2024-11-19T22:24:40.6295802Z updater | rehash: warning: skipping ca-certificates.crt,it does not contain exactly one certificate or CRL
2024-11-19T22:24:40.6363168Z updater | 1 added, 0 removed; done.
2024-11-19T22:24:40.6364244Z Running hooks in /etc/ca-certificates/update.d...
2024-11-19T22:24:40.6378545Z updater | done.
2024-11-19T22:24:40.6835805Z updater | NuGet native updater experiment value: null
2024-11-19T22:24:43.5469562Z updater | 2024/11/19 22:24:43 INFO <job_919589018> Starting job processing
2024-11-19T22:24:43.5478891Z 2024/11/19 22:24:43 INFO <job_919589018> Job definition: {"job":{"allowed-updates":[{"dependency-type":"direct","update-type":"all"}],"commit-message-options":{"prefix":null,"prefix-development":null,"include-scope":null},"credentials-metadata":[{"type":"git_source","host":"github.com"}],"debug":null,"dependencies":null,"dependency-groups":[],"dependency-group-to-refresh":null,"existing-pull-requests":[],"existing-group-pull-requests":[],"experiments":{"record-ecosystem-versions":true,"record-update-job-unknown-error":true,"proxy-cached":true,"move-job-token":true,"dependency-change-validation":true,"nuget-native-analysis":true,"composer-v1-deprecation-warning":true,"composer-v1-unsupported-error":true,"lead-security-dependency":true,"enable-record-ecosystem-meta":true,"enable-corepack-for-npm-and-yarn":true},"ignore-conditions":[],"lockfile-only":false,"max-updater-run-time":2700,"package-manager":"nuget","proxy-log-response-body-on-auth-failure":true,"requirements-update-strategy":null,"reject-external-code":false,"security-advisories":[],"security-updates-only":false,"source":{"provider":"github","repo":"goswinr/DependabotTest","branch":null,"directory":"/.","api-endpoint":"https://api.github.com/","hostname":"github.com"},"updating-a-pull-request":false,"update-subdependencies":false,"vendor-dependencies":false,"repo-private":false}}
2024-11-19T22:24:43.7243883Z   proxy | 2024/11/19 22:24:43 [002] GET https://github.com:443/goswinr/DependabotTest/info/refs?service=git-upload-pack
2024-11-19T22:24:43.7246173Z   proxy | 2024/11/19 22:24:43 [002] * authenticating git server request (host: github.com)
2024-11-19T22:24:43.9235508Z   proxy | 2024/11/19 22:24:43 [002] 200 https://github.com:443/goswinr/DependabotTest/info/refs?service=git-upload-pack
2024-11-19T22:24:43.9551486Z   proxy | 2024/11/19 22:24:43 [004] POST https://github.com:443/goswinr/DependabotTest/git-upload-pack
2024-11-19T22:24:43.9552485Z 2024/11/19 22:24:43 [004] * authenticating git server request (host: github.com)
2024-11-19T22:24:44.0917446Z   proxy | 2024/11/19 22:24:44 [004] 200 https://github.com:443/goswinr/DependabotTest/git-upload-pack
2024-11-19T22:24:44.1255765Z   proxy | 2024/11/19 22:24:44 [006] POST https://github.com:443/goswinr/DependabotTest/git-upload-pack
2024-11-19T22:24:44.1257417Z 2024/11/19 22:24:44 [006] * authenticating git server request (host: github.com)
2024-11-19T22:24:44.2763711Z   proxy | 2024/11/19 22:24:44 [006] 200 https://github.com:443/goswinr/DependabotTest/git-upload-pack
2024-11-19T22:24:44.4243204Z updater | 2024/11/19 22:24:44 INFO <job_919589018> Base commit SHA: 1aef41cb7d3b6daa1472f2870fef3b7493d82f67
2024-11-19T22:24:44.4247912Z updater | 2024/11/19 22:24:44 INFO <job_919589018> Finished job processing
2024-11-19T22:24:44.4614865Z updater | NuGet native updater experiment value: null
2024-11-19T22:24:47.1157840Z updater | 2024/11/19 22:24:47 INFO <job_919589018> Starting job processing
2024-11-19T22:24:47.1756594Z updater | running NuGet discovery:
2024-11-19T22:24:47.1758947Z /opt/nuget/NuGetUpdater/NuGetUpdater.Cli discover --repo-root /home/dependabot/dependabot-updater/repo --workspace / --output /tmp/.dependabot/discovery.1.json
2024-11-19T22:24:48.9389302Z   proxy | 2024/11/19 22:24:48 [008] GET https://api.nuget.org:443/v3/index.json
2024-11-19T22:24:48.9495322Z   proxy | 2024/11/19 22:24:48 [008] 200 https://api.nuget.org:443/v3/index.json
2024-11-19T22:24:48.9936149Z   proxy | 2024/11/19 22:24:48 [010] GET https://api.nuget.org:443/v3-index/repository-signatures/5.0.0/index.json
2024-11-19T22:24:48.9952746Z   proxy | 2024/11/19 22:24:48 [010] 200 https://api.nuget.org:443/v3-index/repository-signatures/5.0.0/index.json
2024-11-19T22:24:49.0357956Z   proxy | 2024/11/19 22:24:49 [012] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.windowsdesktop.app.ref/index.json
2024-11-19T22:24:49.1183598Z   proxy | 2024/11/19 22:24:49 [012] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.windowsdesktop.app.ref/index.json
2024-11-19T22:24:49.1423331Z   proxy | 2024/11/19 22:24:49 [014] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.windowsdesktop.app.ref/8.0.11/microsoft.windowsdesktop.app.ref.8.0.11.nupkg
2024-11-19T22:24:49.1495832Z   proxy | 2024/11/19 22:24:49 [014] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.windowsdesktop.app.ref/8.0.11/microsoft.windowsdesktop.app.ref.8.0.11.nupkg
2024-11-19T22:24:49.7188619Z updater | Discovering build files in workspace [/home/dependabot/dependabot-updater/repo].
2024-11-19T22:24:49.7190066Z   No dotnet-tools.json file found.
2024-11-19T22:24:49.7190781Z   No global.json file found.
2024-11-19T22:24:49.7202555Z   Discovering projects beneath [.].
2024-11-19T22:24:49.7204116Z   No packages.config file found.
2024-11-19T22:24:49.7206288Z   Central Package Management is not enabled.
2024-11-19T22:24:49.7207128Z Discovery complete.
2024-11-19T22:24:49.7208854Z updater | 2024/11/19 22:24:49 INFO <job_919589018> Discovery JSON content: {
2024-11-19T22:24:49.7210083Z   "Path": "",
2024-11-19T22:24:49.7210787Z   "IsSuccess": true,
2024-11-19T22:24:49.7211383Z   "Projects": [
2024-11-19T22:24:49.7211902Z     {
2024-11-19T22:24:49.7212644Z       "FilePath": "DependabotTest.fsproj",
2024-11-19T22:24:49.7213578Z       "Dependencies": [
2024-11-19T22:24:49.7214275Z         {
2024-11-19T22:24:49.7214840Z           "Name": "FSharp.Core",
2024-11-19T22:24:49.7215572Z           "Version": "6.0.7",
2024-11-19T22:24:49.7217665Z           "Type": "PackageReference",
2024-11-19T22:24:49.7218391Z           "EvaluationResult": {
2024-11-19T22:24:49.7219071Z             "ResultType": "Success",
2024-11-19T22:24:49.7220026Z             "OriginalValue": "6.0.7",
2024-11-19T22:24:49.7221037Z             "EvaluatedValue": "6.0.7",
2024-11-19T22:24:49.7221951Z             "RootPropertyName": null,
2024-11-19T22:24:49.7222668Z             "ErrorMessage": null
2024-11-19T22:24:49.7223276Z           },
2024-11-19T22:24:49.7223898Z           "TargetFrameworks": [
2024-11-19T22:24:49.7224526Z             "net8.0"
2024-11-19T22:24:49.7225048Z           ],
2024-11-19T22:24:49.7225673Z           "IsDevDependency": false,
2024-11-19T22:24:49.7226333Z           "IsDirect": true,
2024-11-19T22:24:49.7226955Z           "IsTransitive": false,
2024-11-19T22:24:49.7227635Z           "IsOverride": false,
2024-11-19T22:24:49.7228246Z           "IsUpdate": true,
2024-11-19T22:24:49.7228878Z           "InfoUrl": null
2024-11-19T22:24:49.7229583Z         },
2024-11-19T22:24:49.7230048Z         {
2024-11-19T22:24:49.7230660Z           "Name": "Microsoft.NET.Sdk",
2024-11-19T22:24:49.7231331Z           "Version": null,
2024-11-19T22:24:49.7231938Z           "Type": "MSBuildSdk",
2024-11-19T22:24:49.7232662Z           "EvaluationResult": null,
2024-11-19T22:24:49.7233331Z           "TargetFrameworks": null,
2024-11-19T22:24:49.7233979Z           "IsDevDependency": false,
2024-11-19T22:24:49.7234709Z           "IsDirect": false,
2024-11-19T22:24:49.7235315Z           "IsTransitive": false,
2024-11-19T22:24:49.7235987Z           "IsOverride": false,
2024-11-19T22:24:49.7236749Z           "IsUpdate": false,
2024-11-19T22:24:49.7237366Z           "InfoUrl": null
2024-11-19T22:24:49.7238001Z         }
2024-11-19T22:24:49.7238462Z       ],
2024-11-19T22:24:49.7238925Z       "IsSuccess": true,
2024-11-19T22:24:49.7239577Z       "Properties": [
2024-11-19T22:24:49.7240140Z         {
2024-11-19T22:24:49.7240697Z           "Name": "GenerateDocumentationFile",
2024-11-19T22:24:49.7241499Z           "Value": "true",
2024-11-19T22:24:49.7242183Z           "SourceFilePath": "DependabotTest.fsproj"
2024-11-19T22:24:49.7242917Z         },
2024-11-19T22:24:49.7243554Z         {
2024-11-19T22:24:49.7244071Z           "Name": "TargetFramework",
2024-11-19T22:24:49.7244689Z           "Value": "net8.0",
2024-11-19T22:24:49.7245468Z           "SourceFilePath": "DependabotTest.fsproj"
2024-11-19T22:24:49.7246192Z         }
2024-11-19T22:24:49.7246729Z       ],
2024-11-19T22:24:49.7247248Z       "TargetFrameworks": [
2024-11-19T22:24:49.7248076Z         "net8.0"
2024-11-19T22:24:49.7248682Z       ],
2024-11-19T22:24:49.7249205Z       "ReferencedProjectPaths": []
2024-11-19T22:24:49.7250051Z     }
2024-11-19T22:24:49.7250639Z   ],
2024-11-19T22:24:49.7251146Z   "DirectoryPackagesProps": null,
2024-11-19T22:24:49.7251825Z   "GlobalJson": null,
2024-11-19T22:24:49.7252470Z   "DotNetToolsJson": null,
2024-11-19T22:24:49.7253066Z   "ErrorType": null,
2024-11-19T22:24:49.7253718Z   "ErrorDetails": null
2024-11-19T22:24:49.7254257Z }
2024-11-19T22:24:49.9750670Z   proxy | 2024/11/19 22:24:49 [016] POST /update_jobs/919589018/update_dependency_list
2024-11-19T22:24:50.2883833Z   proxy | 2024/11/19 22:24:50 [016] 204 /update_jobs/919589018/update_dependency_list
2024-11-19T22:24:50.3378644Z   proxy | 2024/11/19 22:24:50 [018] POST /update_jobs/919589018/increment_metric
2024-11-19T22:24:50.4532644Z   proxy | 2024/11/19 22:24:50 [018] 204 /update_jobs/919589018/increment_metric
2024-11-19T22:24:50.4579624Z updater | 2024/11/19 22:24:50 INFO <job_919589018> Starting update job for goswinr/DependabotTest
2024-11-19T22:24:50.4581237Z 2024/11/19 22:24:50 INFO <job_919589018> Checking all dependencies for version updates...
2024-11-19T22:24:50.4595826Z updater | 2024/11/19 22:24:50 INFO <job_919589018> Checking if FSharp.Core 6.0.7 needs updating
2024-11-19T22:24:50.4624275Z updater | 2024/11/19 22:24:50 INFO <job_919589018> Writing dependency info: {"Name":"FSharp.Core","Version":"6.0.7","IsVulnerable":false,"IgnoredVersions":[],"Vulnerabilities":[]}
2024-11-19T22:24:50.4626281Z updater | running NuGet analyze:
2024-11-19T22:24:50.4629767Z /opt/nuget/NuGetUpdater/NuGetUpdater.Cli analyze --repo-root /home/dependabot/dependabot-updater/repo --discovery-file-path /tmp/.dependabot/discovery.1.json --dependency-file-path /tmp/.dependabot/dependency/FSharp.Core.json --analysis-folder-path /tmp/.dependabot/analysis
2024-11-19T22:24:50.9740383Z   proxy | 2024/11/19 22:24:50 [020] GET https://api.nuget.org:443/v3/registration5-gz-semver2/fsharp.core/index.json
2024-11-19T22:24:51.0798303Z   proxy | 2024/11/19 22:24:51 [020] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/fsharp.core/index.json
2024-11-19T22:24:51.2345807Z   proxy | 2024/11/19 22:24:51 [022] GET https://api.nuget.org:443/v3-flatcontainer/fsharp.core/index.json
2024-11-19T22:24:51.3253001Z   proxy | 2024/11/19 22:24:51 [022] 200 https://api.nuget.org:443/v3-flatcontainer/fsharp.core/index.json
2024-11-19T22:24:51.3447935Z   proxy | 2024/11/19 22:24:51 [024] GET https://api.nuget.org:443/v3-flatcontainer/fsharp.core/6.0.7/fsharp.core.6.0.7.nupkg
2024-11-19T22:24:51.3510136Z   proxy | 2024/11/19 22:24:51 [024] 200 https://api.nuget.org:443/v3-flatcontainer/fsharp.core/6.0.7/fsharp.core.6.0.7.nupkg
2024-11-19T22:24:51.7123929Z   proxy | 2024/11/19 22:24:51 [026] GET https://api.nuget.org:443/v3-flatcontainer/fsharp.core/9.0.100/fsharp.core.9.0.100.nupkg
2024-11-19T22:24:51.7162068Z   proxy | 2024/11/19 22:24:51 [026] 200 https://api.nuget.org:443/v3-flatcontainer/fsharp.core/9.0.100/fsharp.core.9.0.100.nupkg
2024-11-19T22:24:53.0326825Z   proxy | 2024/11/19 22:24:53 [028] GET https://api.nuget.org:443/v3/vulnerabilities/index.json
2024-11-19T22:24:53.0340514Z   proxy | 2024/11/19 22:24:53 [028] 200 https://api.nuget.org:443/v3/vulnerabilities/index.json
2024-11-19T22:24:53.0800286Z   proxy | 2024/11/19 22:24:53 [031] GET https://api.nuget.org:443/v3-vulnerabilities/2024.11.19.11.31.42/vulnerability.base.json
2024-11-19T22:24:53.0809697Z   proxy | 2024/11/19 22:24:53 [032] GET https://api.nuget.org:443/v3-vulnerabilities/2024.11.19.11.31.42/2024.11.19.11.31.42/vulnerability.update.json
2024-11-19T22:24:53.0837410Z   proxy | 2024/11/19 22:24:53 [031] 200 https://api.nuget.org:443/v3-vulnerabilities/2024.11.19.11.31.42/vulnerability.base.json
2024-11-19T22:24:53.0879495Z   proxy | 2024/11/19 22:24:53 [032] 200 https://api.nuget.org:443/v3-vulnerabilities/2024.11.19.11.31.42/2024.11.19.11.31.42/vulnerability.update.json
2024-11-19T22:24:53.4913046Z updater | Starting analysis of FSharp.Core...
2024-11-19T22:24:53.4914840Z   Determining multi-dependency property.
2024-11-19T22:24:53.4915584Z   Finding updated version.
2024-11-19T22:24:53.4916102Z   Finding updated peer dependencies.
2024-11-19T22:24:53.4916550Z Analysis complete.
2024-11-19T22:24:53.4917092Z   Writing analysis result to [/tmp/.dependabot/analysis/FSharp.Core.json].
2024-11-19T22:24:53.4928101Z updater | 2024/11/19 22:24:53 INFO <job_919589018> FSharp.Core.json analysis content: {
2024-11-19T22:24:53.4929173Z   "UpdatedVersion": "9.0.100",
2024-11-19T22:24:53.4930237Z   "CanUpdate": true,
2024-11-19T22:24:53.4931107Z   "VersionComesFromMultiDependencyProperty": false,
2024-11-19T22:24:53.4931956Z   "UpdatedDependencies": [
2024-11-19T22:24:53.4932619Z     {
2024-11-19T22:24:53.4933120Z       "Name": "FSharp.Core",
2024-11-19T22:24:53.4933751Z       "Version": "9.0.100",
2024-11-19T22:24:53.4934527Z       "Type": "Unknown",
2024-11-19T22:24:53.4935209Z       "EvaluationResult": null,
2024-11-19T22:24:53.4935684Z       "TargetFrameworks": [
2024-11-19T22:24:53.4936280Z         "net8.0"
2024-11-19T22:24:53.4936782Z       ],
2024-11-19T22:24:53.4937262Z       "IsDevDependency": false,
2024-11-19T22:24:53.4938015Z       "IsDirect": false,
2024-11-19T22:24:53.4938551Z       "IsTransitive": false,
2024-11-19T22:24:53.4939015Z       "IsOverride": false,
2024-11-19T22:24:53.4939391Z       "IsUpdate": false,
2024-11-19T22:24:53.4939876Z       "InfoUrl": "https://github.com/dotnet/fsharp"
2024-11-19T22:24:53.4940390Z     }
2024-11-19T22:24:53.4940697Z   ],
2024-11-19T22:24:53.4940963Z   "ErrorType": null,
2024-11-19T22:24:53.4941391Z   "ErrorDetails": null
2024-11-19T22:24:53.4941751Z }
2024-11-19T22:24:53.4942448Z updater | 2024/11/19 22:24:53 INFO <job_919589018> Latest version is 9.0.100
2024-11-19T22:24:53.5015886Z updater | 2024/11/19 22:24:53 INFO <job_919589018> Requirements to unlock all
2024-11-19T22:24:53.5017379Z 2024/11/19 22:24:53 INFO <job_919589018> Requirements update strategy
2024-11-19T22:24:53.5050450Z updater | 2024/11/19 22:24:53 INFO <job_919589018> Updating FSharp.Core from 6.0.7 to 9.0.100
2024-11-19T22:24:53.5239790Z updater | running NuGet updater:
2024-11-19T22:24:53.5244152Z /opt/nuget/NuGetUpdater/NuGetUpdater.Cli update --job-path /home/dependabot/dependabot-updater/job.json --repo-root /home/dependabot/dependabot-updater/repo --solution-or-project /home/dependabot/dependabot-updater/repo/DependabotTest.fsproj --dependency FSharp.Core --new-version 9.0.100 --previous-version 6.0.7 --result-output-path /tmp/update-result.json
2024-11-19T22:24:55.2303528Z updater | 2024/11/19 22:24:53 INFO Error deserializing job file: System.Text.Json.JsonException: The JSON value could not be converted to System.Boolean. Path: $.job.debug | LineNumber: 0 | BytePositionInLine: 958.
2024-11-19T22:24:55.2306393Z  ---> System.InvalidOperationException: Cannot get the value of a token type 'Null' as a boolean.
2024-11-19T22:24:55.2307480Z    at System.Text.Json.ThrowHelper.ThrowInvalidOperationException_ExpectedBoolean(JsonTokenType tokenType)
2024-11-19T22:24:55.2308500Z    at System.Text.Json.Utf8JsonReader.GetBoolean()
2024-11-19T22:24:55.2309476Z    at System.Text.Json.Serialization.Metadata.JsonPropertyInfo`1.ReadJsonAndSetMember(Object obj, ReadStack& state, Utf8JsonReader& reader)
2024-11-19T22:24:55.2311074Z    at System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1.OnTryRead(Utf8JsonReader& reader, Type typeToConvert, JsonSerializerOptions options, ReadStack& state, T& value)
2024-11-19T22:24:55.2312887Z    at System.Text.Json.Serialization.JsonConverter`1.TryRead(Utf8JsonReader& reader, Type typeToConvert, JsonSerializerOptions options, ReadStack& state, T& value, Boolean& isPopulatedValue)
2024-11-19T22:24:55.2314448Z    at System.Text.Json.Serialization.Metadata.JsonPropertyInfo`1.ReadJsonAndSetMember(Object obj, ReadStack& state, Utf8JsonReader& reader)
2024-11-19T22:24:55.2315986Z    at System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1.OnTryRead(Utf8JsonReader& reader, Type typeToConvert, JsonSerializerOptions options, ReadStack& state, T& value)
2024-11-19T22:24:55.2318046Z    at System.Text.Json.Serialization.JsonConverter`1.TryRead(Utf8JsonReader& reader, Type typeToConvert, JsonSerializerOptions options, ReadStack& state, T& value, Boolean& isPopulatedValue)
2024-11-19T22:24:55.2319597Z    at System.Text.Json.Serialization.JsonConverter`1.ReadCore(Utf8JsonReader& reader, T& value, JsonSerializerOptions options, ReadStack& state)
2024-11-19T22:24:55.2320669Z    --- End of inner exception stack trace ---
2024-11-19T22:24:55.2321450Z    at System.Text.Json.ThrowHelper.ReThrowWithPath(ReadStack& state, Utf8JsonReader& reader, Exception ex)
2024-11-19T22:24:55.2322649Z    at System.Text.Json.Serialization.JsonConverter`1.ReadCore(Utf8JsonReader& reader, T& value, JsonSerializerOptions options, ReadStack& state)
2024-11-19T22:24:55.2323934Z    at System.Text.Json.Serialization.Metadata.JsonTypeInfo`1.Deserialize(Utf8JsonReader& reader, ReadStack& state)
2024-11-19T22:24:55.2325160Z    at System.Text.Json.JsonSerializer.ReadFromSpan[TValue](ReadOnlySpan`1 utf8Json, JsonTypeInfo`1 jsonTypeInfo, Nullable`1 actualByteCount)
2024-11-19T22:24:55.2326340Z    at System.Text.Json.JsonSerializer.ReadFromSpan[TValue](ReadOnlySpan`1 json, JsonTypeInfo`1 jsonTypeInfo)
2024-11-19T22:24:55.2327615Z    at NuGetUpdater.Core.Run.RunWorker.Deserialize(String json) in /opt/nuget/lib/NuGetUpdater/NuGetUpdater.Core/Run/RunWorker.cs:line 381
2024-11-19T22:24:55.2339533Z    at NuGetUpdater.Core.ExperimentsManager.FromJobFileAsync(String jobFilePath, ILogger logger) in /opt/nuget/lib/NuGetUpdater/NuGetUpdater.Core/ExperimentsManager.cs:line 24: {"base64_dependency_files":[{"name":"DependabotTest.fsproj","content":"77u/PFByb2plY3QgU2RrPSJNaWNyb3NvZnQuTkVULlNkayI+CgogIDxQcm9w\nZXJ0eUdyb3VwPgogICAgPFRhcmdldEZyYW1ld29yaz5uZXQ4LjA8L1Rhcmdl\ndEZyYW1ld29yaz4KICAgIDxHZW5lcmF0ZURvY3VtZW50YXRpb25GaWxlPnRy\ndWU8L0dlbmVyYXRlRG9jdW1lbnRhdGlvbkZpbGU+CiAgPC9Qcm9wZXJ0eUdy\nb3VwPgoKICA8SXRlbUdyb3VwPgogICAgPFBhY2thZ2VSZWZlcmVuY2UgVXBk\nYXRlPSJGU2hhcnAuQ29yZSIgVmVyc2lvbj0iNi4wLjciIC8+CiAgICA8Q29t\ncGlsZSBJbmNsdWRlPSJMaWJyYXJ5LmZzIiAvPgogIDwvSXRlbUdyb3VwPgoK\nPC9Qcm9qZWN0Pgo=\n","directory":"/","type":"file","support_file":false,"content_encoding":"utf-8","deleted":false,"operation":"update","mode":null}],"base_commit_sha":"1aef41cb7d3b6daa1472f2870fef3b7493d82f67","job":{"allowed-updates":[{"dependency-type":"direct","update-type":"all"}],"commit-message-options":{"prefix":null,"prefix-development":null,"include-scope":null},"credentials-metadata":[{"type":"git_source","host":"github.com"}],"debug":null,"dependencies":null,"dependency-groups":[],"dependency-group-to-refresh":null,"existing-pull-requests":[],"existing-group-pull-requests":[],"experiments":{"record-ecosystem-versions":true,"record-update-job-unknown-error":true,"proxy-cached":true,"move-job-token":true,"dependency-change-validation":true,"nuget-native-analysis":true,"composer-v1-deprecation-warning":true,"composer-v1-unsupported-error":true,"lead-security-dependency":true,"enable-record-ecosystem-meta":true,"enable-corepack-for-npm-and-yarn":true},"ignore-conditions":[],"lockfile-only":false,"max-updater-run-time":2700,"package-manager":"nuget","proxy-log-response-body-on-auth-failure":true,"requirements-update-strategy":null,"reject-external-code":false,"security-advisories":[],"security-updates-only":false,"source":{"provider":"github","repo":"goswinr/DependabotTest","branch":null,"directory":"/.","api-endpoint":"https://api.github.com/","hostname":"github.com"},"updating-a-pull-request":false,"update-subdependencies":false,"vendor-dependencies":false,"repo-private":false}}
2024-11-19T22:24:55.2350664Z   No dotnet-tools.json file found.
2024-11-19T22:24:55.2351131Z   No global.json file found.
2024-11-19T22:24:55.2351669Z Running for project file [DependabotTest.fsproj]
2024-11-19T22:24:55.2352433Z Updating project [/home/dependabot/dependabot-updater/repo/DependabotTest.fsproj]
2024-11-19T22:24:55.2353195Z   Running 'PackageReference' project direct XML update
2024-11-19T22:24:55.2354453Z     Package [FSharp.Core] Does not exist as a dependency in [/home/dependabot/dependabot-updater/repo/DependabotTest.fsproj].
2024-11-19T22:24:55.2355250Z Update complete.
2024-11-19T22:24:55.2355776Z   Writing update result to [/tmp/update-result.json].
2024-11-19T22:24:55.2356360Z 2024/11/19 22:24:55 INFO <job_919589018> update result: {
2024-11-19T22:24:55.2356861Z   "ErrorType": null,
2024-11-19T22:24:55.2357247Z   "ErrorDetails": null
2024-11-19T22:24:55.2357620Z }
2024-11-19T22:24:55.2897692Z   proxy | 2024/11/19 22:24:55 [034] POST /update_jobs/919589018/record_update_job_error
2024-11-19T22:24:55.4211046Z   proxy | 2024/11/19 22:24:55 [034] 204 /update_jobs/919589018/record_update_job_error
2024-11-19T22:24:55.4231006Z updater | 2024/11/19 22:24:55 INFO <job_919589018> Handled error whilst updating FSharp.Core: update_not_possible {:dependencies=>["FSharp.Core"]}
2024-11-19T22:24:55.4737198Z   proxy | 2024/11/19 22:24:55 [036] PATCH /update_jobs/919589018/mark_as_processed
2024-11-19T22:24:55.6131066Z   proxy | 2024/11/19 22:24:55 [036] 204 /update_jobs/919589018/mark_as_processed
2024-11-19T22:24:55.6161783Z updater | 2024/11/19 22:24:55 INFO <job_919589018> Finished job processing
2024-11-19T22:24:55.6207844Z updater | 2024/11/19 22:24:55 INFO Results:
2024-11-19T22:24:55.6209498Z Dependabot encountered '1' error(s) during execution, please check the logs for more details.
2024-11-19T22:24:55.6211104Z +-----------------------------------+
2024-11-19T22:24:55.6212018Z |   Dependencies failed to update   |
2024-11-19T22:24:55.6212826Z +-------------+---------------------+
2024-11-19T22:24:55.6213631Z | FSharp.Core | update_not_possible |
2024-11-19T22:24:55.6214589Z +-------------+---------------------+
2024-11-19T22:24:55.8173947Z Failure running container 6356a4c35319383f3c9b96b9eeb64b6bd508aae93f37acdb9ab6ff5a6403fdf5
2024-11-19T22:24:55.8410413Z Cleaned up container 6356a4c35319383f3c9b96b9eeb64b6bd508aae93f37acdb9ab6ff5a6403fdf5
2024-11-19T22:24:55.8515106Z   proxy | 2024/11/19 22:24:55 0/18 calls cached (0%)
2024-11-19T22:24:55.8516608Z   proxy | 2024/11/19 22:24:55 Posting metrics to remote API endpoint
2024-11-19T22:24:56.9352977Z ##[error]Dependabot encountered an error performing the update

Error: The updater encountered one or more errors.

For more information see: https://github.com/goswinr/DependabotTest/network/updates/919589018 (write access to the repository is required to view the log)
2024-11-19T22:24:56.9364445Z 🤖 ~ finished: error reported to Dependabot ~
2024-11-19T22:24:56.9444784Z Post job cleanup.
2024-11-19T22:24:57.0756849Z Cleaning up orphan processes
```