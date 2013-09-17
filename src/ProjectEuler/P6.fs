module ProjectEulerP6

let square x = x * x

let problem6 list =  (list |> List.sum |> square) - (list |> List.map square |> List.sum)

let solution = problem6 [1 .. 100]