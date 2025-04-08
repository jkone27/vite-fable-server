namespace App

open Fable.Core.JsInterop
open Fable.Core

module Vi = 
    type IMatcherResult =
        abstract toEqual: obj -> unit

    [<Import("expect", from = "vitest")>]
    let expect(value: obj): IMatcherResult = jsNative

    [<Import("beforeEach", from = "vitest")>]
    let beforeEach(test: unit -> unit) = jsNative

    [<Import("afterEach", from = "vitest")>]
    let afterEach(test: unit -> unit) = jsNative

    [<Import("beforeAll", from = "vitest")>]
    let beforeAll(test: unit -> unit) = jsNative

    [<Import("afterAll", from = "vitest")>]
    let afterAll(test: unit -> unit) = jsNative

    [<Import("it", from = "vitest")>]
    let it(name: string, test: unit -> unit) = jsNative

    [<Import("test", from = "vitest")>]
    let test(name: string, test: unit -> unit) = jsNative

    [<Import("describe", from = "vitest")>]
    let describe(name: string, testSuite: unit -> unit) = jsNative 


module Test =
    
    Vi.describe("Hello world", fun () ->
        Vi.it("should be true", fun () ->
            Vi.expect(true).toEqual(true)
        )
    )