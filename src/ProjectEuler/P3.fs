module ProjectEulerP3

//TODO: not working
let getAllPrimesUnder n =
    let numbers = Array.init n (fun x -> true)
    let rec cycle i =
        if numbers.[i] && i*i < n then
            for j in i * i .. (n - 1) do
                numbers.[j] <- false
        cycle (i + 1)
    cycle 2 |> ignore
    numbers


let getBiggestPrime = getAllPrimesUnder 1000
