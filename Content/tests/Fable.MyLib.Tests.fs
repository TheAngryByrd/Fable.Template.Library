module Fable.MyLib.Tests

open Fable.Core
open Fable.Core.JsInterop
open Fable.MyLib

let inline equal (expected: 'T) (actual: 'T): unit =
    let assert' = importAll<obj> "assert"
    assert'?deepStrictEqual(actual, expected) |> ignore

[<Global>]
let it (msg: string) (f: unit->unit): unit = jsNative

it "Adding works" <| fun () ->
    add 1 2  |> equal (3)
