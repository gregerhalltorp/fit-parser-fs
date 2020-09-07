module FitFileTests

open NUnit.Framework
open FsUnit
open FitParse
open BinParser

[<Test>]
let ``fileParser succeds bogus`` () =
  true |> should equal true