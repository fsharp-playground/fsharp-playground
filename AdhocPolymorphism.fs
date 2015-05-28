module polymorephiscm =

    type A = { thing: int }
        with static member show a = sprintf "%A" a
    type B = { label: string}
        with static member show b = sprintf "%A" b

    let inline show(x: ^t) =
        (^t: (static member show: ^t -> string) (x))

    { thing = 98 } |> show
    |> ignore

    { label = "Car" } |> show
    |> ignore
