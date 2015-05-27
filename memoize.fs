
open System.Collections.Generic
open System

#nowarn "40"

let memoize f =
    let cache = Dictionary<_, _>()
    fun x ->
        let ok,res = cache.TryGetValue(x)
        if ok then
            res
        else
            let res = f x
            cache.[x] <- res
            res


let rec fib = memoize(function
  | 1 -> 1
  | 2 -> 1
  | n -> fib(n-1) + fib(n-2))

let fibs =
    let rec fb n =
        seq {
            yield fib n
            yield! fb (n+1)
        }
    fb 2

fibs |> Seq.takeWhile((>=) 4000000) |> Seq.filter(fun fib -> fib % 2 = 0) |> Seq.sum
