
type Data =
    | A of int
    | B of string

let show input=
    match input with
    | A thing -> sprintf "%d" thing
    | B label -> sprintf "%s" label

A 98 |> show
B "Car" |> show

