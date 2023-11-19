// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    // let message = from "F#" // Call the function
    // printfn "Hello world %s" message
    // System.Console.Write "Type something:"
    // let str = System.Console.ReadLine()
    // printfn "You typed %s" str

    printfn "number 1 ?"
    let no1 = System.Console.ReadLine()
    printfn "number 2 ?"
    let no2 = System.Console.ReadLine()
    printfn "1: %s, 2: %s" no1 no2
    let sum = (int no1) + (int no2)
    printfn "sum: %i" sum

    0 // return an integer exit code