

open System.Linq

let mutable k = 0
let aeiou =
    k <- k + 1
    let ls = ["a"; "e"; "e"; "i"; "o"; "u"]
    fun input -> ls.Contains(input)

aeiou "a"
aeiou "c"
k
k
aeiou "c"
k
aeiou "u"
k
k







