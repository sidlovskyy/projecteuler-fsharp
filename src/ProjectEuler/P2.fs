module ProjectEulerP2

let generateFibonaci = 
    Seq.unfold (fun (prev, current) -> Some(prev, (current, prev + current))) (1, 2)

let getFibonaciSum = 
    generateFibonaci |> Seq.takeWhile (fun n -> n <= 4000000) |> Seq.filter (fun n -> n % 2 = 0) |> Seq.sum