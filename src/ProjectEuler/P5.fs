module ProjectEulerP5

let rec gcd(a, b) = match b with | 0 -> a | _ -> gcd(b, a % b)

let lcm(a, b) = a / gcd(a, b) * b

let solution = [1 .. 20] |> List.fold (fun acc elem -> lcm(acc, elem)) 1