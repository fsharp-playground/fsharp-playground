open System

let add x y = x + y

add 10 20
add 20 40
add 1 2

let ls = [ for x in 1..10 -> x]
ls |> List.filter (fun x -> x % 2 = 0)
ls |> List.filter (fun x -> x % 5 = 0)
ls |> List.head
ls |> List.append [10]
