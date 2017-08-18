module Tests

open Fable.Core.JsInterop

// This is necessary to make webpack collect all test files
importAll "./Fable.MyLib.Tests.fs"
