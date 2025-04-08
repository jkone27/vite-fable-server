#r "nuget: FSharp.Data"
#r "nuget: Fli"
open FSharp.Data
open System
open Fli
open System.Threading.Tasks
open System.Text.RegularExpressions

let printColor consoleColor msg = 
    Console.ForegroundColor <- consoleColor
    printfn "%s" msg
    Console.ResetColor()

let printGreen = printColor ConsoleColor.Green
let printRed = printColor ConsoleColor.Red

let describe suite test =
    printfn suite 
    try
        test()
        printGreen "Test passed"
        0
    with
        | ex -> 
            printRed "Test failed"
            printfn "%s" ex.Message
            -1

let ``prints hello world`` () = 
    describe "prints hello world" <| fun () -> 
        let res = Http.RequestString("http://localhost:3000")

        if res.Contains("Hello World") |> not then
            failwith "Expected 'Hello World' in response"

#time on

// https://github.com/CaptnCodr/Fli
let bunRunDev = 
    cli {
        Shell ZSH
        Command "bun run dev" // send output to stdout? 
        CancelAfter 5000
    }
    |> Command.executeAsync
    |> Async.StartAsTask

``prints hello world`` ()

try
    bunRunDev 
    |> Async.AwaitTask  
    |> Async.RunSynchronously
    |> Output.printExitCode
with ex -> 
    ()

#time off

