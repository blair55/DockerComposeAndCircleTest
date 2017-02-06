#r "./packages/FAKE/tools/FakeLib.dll"

open Fake

let buildDir  = "./build/"

Target "Clean" (fun _ ->
    CleanDirs [buildDir])

Target "Build" (fun _ ->
    ["./MyMonoProj/MyMonoProj.fsproj"]
    |> MSBuildRelease buildDir "Build"
    |> Log "")

"Clean"
  ==> "Build"

RunTargetOrDefault "Build"