module ProjectEulerP1

let sumOfMultiples a1 a2 n =
    [1 .. (n - 1)] |> List.filter (fun x -> (x % a1 = 0) || (x % a2 = 0)) |> List.sum    
