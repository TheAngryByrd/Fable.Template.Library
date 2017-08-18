module Fable.MyLib

open System
open Fable.Core
open Fable.PowerPack

[<Emit("$0 + $1")>]
let add (x: int) (y: int) = jsNative

[<Import("parseJson", "./custom.js")>]
let parseJson : string -> obj option = jsNative


let foo () = 3
