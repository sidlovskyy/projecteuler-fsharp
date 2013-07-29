// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
module ProjectEuler

open ProjectEulerP1
open ProjectEulerP2
open ProjectEulerP4
open ProjectEulerP6

[<EntryPoint>]
let main argv = 
    printfn "%d" (sumOfMultiples 3 5 1000)
    printfn "%d" getFibonaciSum
    printfn "%d" solvep4.Value
    printfn "%d"(problem6 [1 .. 100])

    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
