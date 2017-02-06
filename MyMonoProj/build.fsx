#r "packages/FAKE/tools/FakeLib.dll"

open Fake

let buildDir  = "./build/"

Target "Clean" (fun _ ->
    CleanDirs [buildDir])

Target "Compile" (fun _ ->
    ["./MyMonoProj.fsproj"]
    |> MSBuildRelease buildDir "Build"
    |> Log "")

"Clean"
  ==> "Compile"

RunTargetOrDefault "Compile"