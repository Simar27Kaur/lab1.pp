// For more information see https://aka.ms/fsharp-console-apps

// part 1
let rec product lst acc =
    match lst with
    | [] -> acc 
    | x :: y -> product y (acc * x) 

let numbers = [1; 2; 3; 4; 5]
let res = product numbers 1 
printfn "%A" res


//part 2
let rec productOdd a acc =
    if a <= 1 then
        acc 
    else
        productOdd (a - 2) (acc * a) 

let b = productOdd 11 1 
printfn "%A" b


//part 3
let n = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]

let m = n |> List.map (fun name -> name.Trim())

printfn "%A" m


//part 4

let f x = x % 7 = 0 && x % 5 = 0 
let p = [1 .. 700]

let r = p |> List.filter f
let combined = r |> Seq.reduce (+)

printfn "%A" combined


//part 5
let l = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]
let i = l |> List.filter (fun name -> name.Contains("l"))

let z = i |> Seq.fold (+) ""

printfn "%A" z
