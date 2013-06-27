module ProjectEulerP4
//very stupid solution but it works

let reverse (s : string) =
    new string(Array.rev (s.ToCharArray()))

let (|IsPalindrom|_|) (n : int) = 
    let nStr = n.ToString()    
    if (nStr = (reverse nStr)) then Some(n) else None

let solveForNumbers x y =
    let allProducts = [ for i in 0 .. x do
                            for j in 0 .. y -> i * j ]  
    let rec findFirstPalindrom list =
        match list with
        | [] -> None
        | head :: tail -> match head with 
                          | IsPalindrom z -> Some z
                          | _ -> findFirstPalindrom tail
    allProducts |> List.sort |> List.rev |> findFirstPalindrom

let solvep4 = solveForNumbers 999 999