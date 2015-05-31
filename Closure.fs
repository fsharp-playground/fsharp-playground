let mutable k = 0
let aeiou input =
    k <- k + 1
    let ls = ["a"; "e"; "i"; "o"; "u";]
    input -> ls.Contains(input)

aeiou "a"
k
aeiou "e"
k
aeiou "k"
k