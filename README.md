# DependabotTest

[![Dependabot Updates](https://github.com/goswinr/DependabotTest/actions/workflows/dependabot/dependabot-updates/badge.svg)](https://github.com/goswinr/DependabotTest/actions/workflows/dependabot/dependabot-updates)

To demonstrate that dependabot is not able to update FSharp.Core

see https://github.com/dependabot/dependabot-core/issues/10883

The below log is after the initial fix: https://github.com/dependabot/dependabot-core/pull/10974


## Log

```log

```

Full log:

```log
Run github/dependabot-action@main
🤖 ~ starting update ~
Fetching job details
Pulling updater images
Starting update process
Created proxy container: 477c589a5b53073e7570ce549da14b0d64c48b380407ed38458919ee8a6f24b6
Created container: a7412d928b3ebebc1ec9a898ece6b2bf02519b204d518f3118551b4bb75bd83c
  proxy | 2024/11/24 11:34:13 proxy starting, commit: 4ff727a3a0f3cf493d1700d4ceec3c6f880b430e
  proxy | 2024/11/24 11:34:13 Listening (:1080)
updater | Updating certificates in /etc/ssl/certs...
updater | rehash: warning: skipping ca-certificates.crt,it does not contain exactly one certificate or CRL
updater | 1 added, 0 removed; done.
updater | Running hooks in /etc/ca-certificates/update.d...
updater | done.
updater | NuGet native updater experiment value: null
updater | 2024/11/24 11:34:17 INFO <job_921508326> Starting job processing
2024/11/24 11:34:17 INFO <job_921508326> Job definition: {"job":{"allowed-updates":[{"dependency-type":"direct","update-type":"all"}],"commit-message-options":{"prefix":null,"prefix-development":null,"include-scope":null},"credentials-metadata":[{"type":"git_source","host":"github.com"}],"debug":null,"dependencies":null,"dependency-groups":[],"dependency-group-to-refresh":null,"existing-pull-requests":[],"existing-group-pull-requests":[],"experiments":{"record-ecosystem-versions":true,"record-update-job-unknown-error":true,"proxy-cached":true,"move-job-token":true,"dependency-change-validation":true,"nuget-native-analysis":true,"nuget-use-direct-discovery":true,"lead-security-dependency":true,"enable-record-ecosystem-meta":true},"ignore-conditions":[],"lockfile-only":false,"max-updater-run-time":2700,"package-manager":"nuget","proxy-log-response-body-on-auth-failure":true,"requirements-update-strategy":null,"reject-external-code":false,"security-advisories":[],"security-updates-only":false,"source":{"provider":"github","repo":"goswinr/DependabotTest","branch":null,"directory":"/.","api-endpoint":"https://api.github.com/","hostname":"github.com"},"updating-a-pull-request":false,"update-subdependencies":false,"vendor-dependencies":false,"repo-private":false}}
  proxy | 2024/11/24 11:34:18 [002] GET https://github.com:443/goswinr/DependabotTest/info/refs?service=git-upload-pack
2024/11/24 11:34:18 [002] * authenticating git server request (host: github.com)
  proxy | 2024/11/24 11:34:18 [002] 200 https://github.com:443/goswinr/DependabotTest/info/refs?service=git-upload-pack
  proxy | 2024/11/24 11:34:18 [004] POST https://github.com:443/goswinr/DependabotTest/git-upload-pack
2024/11/24 11:34:18 [004] * authenticating git server request (host: github.com)
  proxy | 2024/11/24 11:34:18 [004] 200 https://github.com:443/goswinr/DependabotTest/git-upload-pack
  proxy | 2024/11/24 11:34:18 [006] POST https://github.com:443/goswinr/DependabotTest/git-upload-pack
2024/11/24 11:34:18 [006] * authenticating git server request (host: github.com)
  proxy | 2024/11/24 11:34:18 [006] 200 https://github.com:443/goswinr/DependabotTest/git-upload-pack
updater | 2024/11/24 11:34:18 INFO <job_921508326> Base commit SHA: 507717bd59a093a6db66966e4a1f29ac86038f0b
updater | 2024/11/24 11:34:18 INFO <job_921508326> Finished job processing
updater | NuGet native updater experiment value: null
updater | 2024/11/24 11:34:21 INFO <job_921508326> Starting job processing
updater | running NuGet discovery:
/opt/nuget/NuGetUpdater/NuGetUpdater.Cli discover --job-path /home/dependabot/dependabot-updater/job.json --repo-root /home/dependabot/dependabot-updater/repo --workspace / --output /tmp/.dependabot/discovery.1.json
  proxy | 2024/11/24 11:34:22 [008] GET https://api.nuget.org:443/v3/index.json
  proxy | 2024/11/24 11:34:22 [008] 200 https://api.nuget.org:443/v3/index.json
  proxy | 2024/11/24 11:34:22 [020] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.net8.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [022] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.maccatalyst.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [023] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.maui.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [024] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.net6.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [025] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.current.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [026] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.android.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [029] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.tvos.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [031] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.net7.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [032] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.current.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [033] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.ios.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [034] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.net7.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [035] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.macos.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [036] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.net6.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [037] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.net8.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [038] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.aspire.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [020] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.net8.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [023] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.maui.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [022] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.maccatalyst.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [026] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.android.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [024] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.net6.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [032] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.current.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [029] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.tvos.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [031] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.net7.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [025] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.current.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [033] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.ios.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [034] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.net7.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [035] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.macos.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [036] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.net6.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [037] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.net8.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:22 [038] 404 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.aspire.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [040] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.android.manifest-9.0.100/index.json
2024/11/24 11:34:23 [040] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.android.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [047] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.macos.manifest-9.0.100/index.json
2024/11/24 11:34:23 [047] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.macos.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [053] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.ios.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [053] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.ios.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [058] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.maui.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [058] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.maui.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [059] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.net6.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [059] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.net6.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [061] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.net8.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [060] GET https://api.nuget.org:443/v3-index/repository-signatures/5.0.0/index.json
  proxy | 2024/11/24 11:34:23 [063] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.net8.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [063] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.net8.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [061] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.net8.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [064] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.net7.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [065] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.aspire.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [062] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.net7.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [060] 200 https://api.nuget.org:443/v3-index/repository-signatures/5.0.0/index.json
  proxy | 2024/11/24 11:34:23 [066] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.maccatalyst.manifest-9.0.100/index.json
2024/11/24 11:34:23 [064] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.net7.manifest-9.0.100/index.json
2024/11/24 11:34:23 [065] 404 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.aspire.manifest-9.0.100/index.json
2024/11/24 11:34:23 [062] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.net7.manifest-9.0.100/index.json
2024/11/24 11:34:23 [066] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.maccatalyst.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [067] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.current.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [067] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.current.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [069] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.tvos.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [069] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.tvos.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [068] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.net6.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [068] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.emscripten.net6.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [070] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.current.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [070] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.workload.mono.toolchain.current.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [072] GET https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.aspire.manifest-8.0.100/index.json
  proxy | 2024/11/24 11:34:23 [083] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.ios.manifest-9.0.100/index.json
2024/11/24 11:34:23 [084] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.net6.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [085] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.net8.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [086] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.net7.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [087] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.android.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [090] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.macos.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [091] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.net8.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [094] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.maui.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [095] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.net7.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [096] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.maccatalyst.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [097] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.current.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [098] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.current.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [100] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.tvos.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [099] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.net6.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [072] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/microsoft.net.sdk.aspire.manifest-8.0.100/index.json
  proxy | 2024/11/24 11:34:23 [102] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.aspire.manifest-8.0.100/index.json
  proxy | 2024/11/24 11:34:23 [083] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.ios.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [084] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.net6.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [091] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.net8.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [087] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.android.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [090] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.macos.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [086] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.net7.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [105] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.ios.manifest-9.0.100/18.0.9617/microsoft.net.sdk.ios.manifest-9.0.100.18.0.9617.nupkg
  proxy | 2024/11/24 11:34:23 [094] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.maui.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [095] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.net7.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [085] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.net8.manifest-9.0.100/index.json
2024/11/24 11:34:23 [096] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.maccatalyst.manifest-9.0.100/index.json
2024/11/24 11:34:23 [106] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.net6.manifest-9.0.100/9.0.0/microsoft.net.workload.mono.toolchain.net6.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [106] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.net6.manifest-9.0.100/9.0.0/microsoft.net.workload.mono.toolchain.net6.manifest-9.0.100.9.0.0.nupkg
2024/11/24 11:34:23 [105] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.ios.manifest-9.0.100/18.0.9617/microsoft.net.sdk.ios.manifest-9.0.100.18.0.9617.nupkg
2024/11/24 11:34:23 [099] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.net6.manifest-9.0.100/index.json
2024/11/24 11:34:23 [100] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.tvos.manifest-9.0.100/index.json
2024/11/24 11:34:23 [098] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.current.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [097] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.current.manifest-9.0.100/index.json
  proxy | 2024/11/24 11:34:23 [111] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.maccatalyst.manifest-9.0.100/18.0.9617/microsoft.net.sdk.maccatalyst.manifest-9.0.100.18.0.9617.nupkg
  proxy | 2024/11/24 11:34:23 [115] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.maui.manifest-9.0.100/9.0.0/microsoft.net.sdk.maui.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [102] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.aspire.manifest-8.0.100/index.json
  proxy | 2024/11/24 11:34:23 [111] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.maccatalyst.manifest-9.0.100/18.0.9617/microsoft.net.sdk.maccatalyst.manifest-9.0.100.18.0.9617.nupkg
  proxy | 2024/11/24 11:34:23 [121] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.net8.manifest-9.0.100/9.0.0/microsoft.net.workload.mono.toolchain.net8.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [115] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.maui.manifest-9.0.100/9.0.0/microsoft.net.sdk.maui.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [121] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.net8.manifest-9.0.100/9.0.0/microsoft.net.workload.mono.toolchain.net8.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [122] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.current.manifest-9.0.100/9.0.0/microsoft.net.workload.emscripten.current.manifest-9.0.100.9.0.0.nupkg
2024/11/24 11:34:23 [125] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.net7.manifest-9.0.100/9.0.0/microsoft.net.workload.mono.toolchain.net7.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [124] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.android.manifest-9.0.100/35.0.7/microsoft.net.sdk.android.manifest-9.0.100.35.0.7.nupkg
2024/11/24 11:34:23 [126] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.net6.manifest-9.0.100/9.0.0/microsoft.net.workload.emscripten.net6.manifest-9.0.100.9.0.0.nupkg
2024/11/24 11:34:23 [127] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.net7.manifest-9.0.100/9.0.0/microsoft.net.workload.emscripten.net7.manifest-9.0.100.9.0.0.nupkg
2024/11/24 11:34:23 [128] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.tvos.manifest-9.0.100/18.0.9617/microsoft.net.sdk.tvos.manifest-9.0.100.18.0.9617.nupkg
  proxy | 2024/11/24 11:34:23 [129] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.macos.manifest-9.0.100/15.0.9617/microsoft.net.sdk.macos.manifest-9.0.100.15.0.9617.nupkg
  proxy | 2024/11/24 11:34:23 [125] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.net7.manifest-9.0.100/9.0.0/microsoft.net.workload.mono.toolchain.net7.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [124] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.android.manifest-9.0.100/35.0.7/microsoft.net.sdk.android.manifest-9.0.100.35.0.7.nupkg
  proxy | 2024/11/24 11:34:23 [126] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.net6.manifest-9.0.100/9.0.0/microsoft.net.workload.emscripten.net6.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [127] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.net7.manifest-9.0.100/9.0.0/microsoft.net.workload.emscripten.net7.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [128] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.tvos.manifest-9.0.100/18.0.9617/microsoft.net.sdk.tvos.manifest-9.0.100.18.0.9617.nupkg
  proxy | 2024/11/24 11:34:23 [122] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.current.manifest-9.0.100/9.0.0/microsoft.net.workload.emscripten.current.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [129] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.macos.manifest-9.0.100/15.0.9617/microsoft.net.sdk.macos.manifest-9.0.100.15.0.9617.nupkg
  proxy | 2024/11/24 11:34:23 [130] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.net8.manifest-9.0.100/9.0.0/microsoft.net.workload.emscripten.net8.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [131] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.current.manifest-9.0.100/9.0.0/microsoft.net.workload.mono.toolchain.current.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [130] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.emscripten.net8.manifest-9.0.100/9.0.0/microsoft.net.workload.emscripten.net8.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [131] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.workload.mono.toolchain.current.manifest-9.0.100/9.0.0/microsoft.net.workload.mono.toolchain.current.manifest-9.0.100.9.0.0.nupkg
  proxy | 2024/11/24 11:34:23 [132] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.aspire.manifest-8.0.100/8.2.2/microsoft.net.sdk.aspire.manifest-8.0.100.8.2.2.nupkg
  proxy | 2024/11/24 11:34:23 [132] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.net.sdk.aspire.manifest-8.0.100/8.2.2/microsoft.net.sdk.aspire.manifest-8.0.100.8.2.2.nupkg
  proxy | 2024/11/24 11:34:23 [134] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.windowsdesktop.app.ref/index.json
  proxy | 2024/11/24 11:34:23 [134] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.windowsdesktop.app.ref/index.json
  proxy | 2024/11/24 11:34:23 [136] GET https://api.nuget.org:443/v3-flatcontainer/microsoft.windowsdesktop.app.ref/8.0.11/microsoft.windowsdesktop.app.ref.8.0.11.nupkg
  proxy | 2024/11/24 11:34:23 [136] 200 https://api.nuget.org:443/v3-flatcontainer/microsoft.windowsdesktop.app.ref/8.0.11/microsoft.windowsdesktop.app.ref.8.0.11.nupkg
updater | Discovering build files in workspace [/home/dependabot/dependabot-updater/repo].
  No dotnet-tools.json file found.
  No global.json file found.
  Discovering projects beneath [.].
  No packages.config file found.
Discovery complete.
updater | 2024/11/24 11:34:24 INFO <job_921508326> Discovery JSON content: {
  "Path": "",
  "IsSuccess": true,
  "Projects": [
    {
      "FilePath": "DependabotTest.fsproj",
      "Dependencies": [
        {
          "Name": "FSharp.Core",
          "Version": "6.0.7",
          "Type": "PackageReference",
          "EvaluationResult": {
            "ResultType": "Success",
            "OriginalValue": "6.0.7",
            "EvaluatedValue": "6.0.7",
            "RootPropertyName": null,
            "ErrorMessage": null
          },
          "TargetFrameworks": [
            "net8.0"
          ],
          "IsDevDependency": false,
          "IsDirect": true,
          "IsTransitive": false,
          "IsOverride": false,
          "IsUpdate": true,
          "InfoUrl": null
        }
      ],
      "IsSuccess": true,
      "Properties": [
        {
          "Name": "GenerateDocumentationFile",
          "Value": "true",
          "SourceFilePath": "DependabotTest.fsproj"
        },
        {
          "Name": "TargetFramework",
          "Value": "net8.0",
          "SourceFilePath": "DependabotTest.fsproj"
        }
      ],
      "TargetFrameworks": [
        "net8.0"
      ],
      "ReferencedProjectPaths": [],
      "ImportedFiles": [],
      "AdditionalFiles": []
    }
  ],
  "GlobalJson": null,
  "DotNetToolsJson": null,
  "ErrorType": null,
  "ErrorDetails": null
}
  proxy | 2024/11/24 11:34:24 [138] POST /update_jobs/921508326/update_dependency_list
  proxy | 2024/11/24 11:34:24 [138] 204 /update_jobs/921508326/update_dependency_list
  proxy | 2024/11/24 11:34:24 [140] POST /update_jobs/921508326/increment_metric
  proxy | 2024/11/24 11:34:24 [140] 204 /update_jobs/921508326/increment_metric
updater | 2024/11/24 11:34:24 INFO <job_921508326> Starting update job for goswinr/DependabotTest
2024/11/24 11:34:24 INFO <job_921508326> Checking all dependencies for version updates...
updater | 2024/11/24 11:34:24 INFO <job_921508326> Checking if FSharp.Core 6.0.7 needs updating
updater | 2024/11/24 11:34:24 INFO <job_921508326> Writing dependency info: {"Name":"FSharp.Core","Version":"6.0.7","IsVulnerable":false,"IgnoredVersions":[],"Vulnerabilities":[]}
updater | running NuGet analyze:
/opt/nuget/NuGetUpdater/NuGetUpdater.Cli analyze --repo-root /home/dependabot/dependabot-updater/repo --discovery-file-path /tmp/.dependabot/discovery.1.json --dependency-file-path /tmp/.dependabot/dependency/FSharp.Core.json --analysis-folder-path /tmp/.dependabot/analysis
  proxy | 2024/11/24 11:34:25 [142] GET https://api.nuget.org:443/v3/registration5-gz-semver2/fsharp.core/index.json
  proxy | 2024/11/24 11:34:25 [142] 200 https://api.nuget.org:443/v3/registration5-gz-semver2/fsharp.core/index.json
  proxy | 2024/11/24 11:34:25 [144] GET https://api.nuget.org:443/v3-flatcontainer/fsharp.core/index.json
  proxy | 2024/11/24 11:34:25 [144] 200 https://api.nuget.org:443/v3-flatcontainer/fsharp.core/index.json
  proxy | 2024/11/24 11:34:25 [146] GET https://api.nuget.org:443/v3-flatcontainer/fsharp.core/6.0.7/fsharp.core.6.0.7.nupkg
  proxy | 2024/11/24 11:34:25 [146] 200 https://api.nuget.org:443/v3-flatcontainer/fsharp.core/6.0.7/fsharp.core.6.0.7.nupkg
  proxy | 2024/11/24 11:34:25 [148] GET https://api.nuget.org:443/v3-flatcontainer/fsharp.core/9.0.100/fsharp.core.9.0.100.nupkg
  proxy | 2024/11/24 11:34:26 [148] 200 https://api.nuget.org:443/v3-flatcontainer/fsharp.core/9.0.100/fsharp.core.9.0.100.nupkg
  proxy | 2024/11/24 11:34:27 [150] GET https://api.nuget.org:443/v3/vulnerabilities/index.json
  proxy | 2024/11/24 11:34:27 [150] 200 https://api.nuget.org:443/v3/vulnerabilities/index.json
  proxy | 2024/11/24 11:34:27 [153] GET https://api.nuget.org:443/v3-vulnerabilities/2024.11.22.23.36.02/2024.11.24.05.36.05/vulnerability.update.json
  proxy | 2024/11/24 11:34:27 [154] GET https://api.nuget.org:443/v3-vulnerabilities/2024.11.22.23.36.02/vulnerability.base.json
  proxy | 2024/11/24 11:34:27 [153] 200 https://api.nuget.org:443/v3-vulnerabilities/2024.11.22.23.36.02/2024.11.24.05.36.05/vulnerability.update.json
  proxy | 2024/11/24 11:34:27 [154] 200 https://api.nuget.org:443/v3-vulnerabilities/2024.11.22.23.36.02/vulnerability.base.json
updater | Starting analysis of FSharp.Core...
  Determining multi-dependency property.
  Finding updated version.
  Finding updated peer dependencies.
Analysis complete.
  Writing analysis result to [/tmp/.dependabot/analysis/FSharp.Core.json].
updater | 2024/11/24 11:34:27 INFO <job_921508326> FSharp.Core.json analysis content: {
  "UpdatedVersion": "9.0.100",
  "CanUpdate": true,
  "VersionComesFromMultiDependencyProperty": false,
  "UpdatedDependencies": [
    {
      "Name": "FSharp.Core",
      "Version": "9.0.100",
      "Type": "Unknown",
      "EvaluationResult": null,
      "TargetFrameworks": [
        "net8.0"
      ],
      "IsDevDependency": false,
      "IsDirect": false,
      "IsTransitive": false,
      "IsOverride": false,
      "IsUpdate": false,
      "InfoUrl": "https://github.com/dotnet/fsharp"
    }
  ],
  "ErrorType": null,
  "ErrorDetails": null
}
updater | 2024/11/24 11:34:27 INFO <job_921508326> Latest version is 9.0.100
updater | 2024/11/24 11:34:27 INFO <job_921508326> Requirements to unlock all
2024/11/24 11:34:27 INFO <job_921508326> Requirements update strategy
updater | 2024/11/24 11:34:27 INFO <job_921508326> Updating FSharp.Core from 6.0.7 to 9.0.100
updater | running NuGet updater:
/opt/nuget/NuGetUpdater/NuGetUpdater.Cli update --job-path /home/dependabot/dependabot-updater/job.json --repo-root /home/dependabot/dependabot-updater/repo --solution-or-project /home/dependabot/dependabot-updater/repo/DependabotTest.fsproj --dependency FSharp.Core --new-version 9.0.100 --previous-version 6.0.7 --result-output-path /tmp/update-result.json
updater |   No dotnet-tools.json file found.
  No global.json file found.
Running for project file [DependabotTest.fsproj]
Updating project [/home/dependabot/dependabot-updater/repo/DependabotTest.fsproj]
  Running 'PackageReference' project direct XML update
    Package [FSharp.Core] Does not exist as a dependency in [/home/dependabot/dependabot-updater/repo/DependabotTest.fsproj].
Update complete.
  Writing update result to [/tmp/update-result.json].
updater | 2024/11/24 11:34:29 INFO <job_921508326> update result: {
  "ErrorType": null,
  "ErrorDetails": null
}
  proxy | 2024/11/24 11:34:29 [156] POST /update_jobs/921508326/record_update_job_error
  proxy | 2024/11/24 11:34:29 [156] 204 /update_jobs/921508326/record_update_job_error
updater | 2024/11/24 11:34:29 INFO <job_921508326> Handled error whilst updating FSharp.Core: update_not_possible {:dependencies=>["FSharp.Core"]}
  proxy | 2024/11/24 11:34:29 [158] PATCH /update_jobs/921508326/mark_as_processed
  proxy | 2024/11/24 11:34:29 [158] 204 /update_jobs/921508326/mark_as_processed
updater | 2024/11/24 11:34:29 INFO <job_921508326> Finished job processing
updater | 2024/11/24 11:34:29 INFO Results:
Dependabot encountered '1' error(s) during execution, please check the logs for more details.
+-----------------------------------+
|   Dependencies failed to update   |
+-------------+---------------------+
| FSharp.Core | update_not_possible |
+-------------+---------------------+
Failure running container a7412d928b3ebebc1ec9a898ece6b2bf02519b204d518f3118551b4bb75bd83c
Cleaned up container a7412d928b3ebebc1ec9a898ece6b2bf02519b204d518f3118551b4bb75bd83c
  proxy | 2024/11/24 11:34:30 15/79 calls cached (18%)
2024/11/24 11:34:30 Posting metrics to remote API endpoint
Error: Dependabot encountered an error performing the update

Error: The updater encountered one or more errors.

For more information see: https://github.com/goswinr/DependabotTest/network/updates/921508326 (write access to the repository is required to view the log)
🤖 ~ finished: error reported to Dependabot ~
```