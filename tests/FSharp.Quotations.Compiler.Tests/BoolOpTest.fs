﻿namespace FSharp.Quotations.Compiler.Tests

[<TestModule>]
module BoolOpTest =
  [<TestCase(true, true, true)>]
  [<TestCase(true, false, true)>]
  [<TestCase(false, true, true)>]
  [<TestCase(false, false, false)>]
  let ``bool || bool`` (x, y, expected) =
    <@ x || y @> |> check expected

  [<TestCase(true, true, true)>]
  [<TestCase(true, false, false)>]
  [<TestCase(false, true, false)>]
  [<TestCase(false, false, false)>]
  let ``bool && bool`` (x, y, expected) =
    <@ x && y @> |> check expected