// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
module ProjectEuler

open ProjectEulerP1

[<EntryPoint>]
let main argv = 
    printfn "%d" (sumOfMultiples 3 5 1000)
    0 // return an integer exit code
