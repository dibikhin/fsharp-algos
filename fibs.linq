<Query Kind="FSharpProgram" />

let fib a b lim =
    let rec fibRec n m =
            match m with
            | d when d >= lim -> m
            | d when d < lim -> fibRec m (n + m)
    fibRec a b
fib 1 2 6 |> Dump

let fibSeq a b =
    let rec fibRec n m =
        seq {
            yield m
            yield! fibRec m (n + m) 
        }
    seq {
        yield a
        yield! fibRec a b
    }
fibSeq 1 2 |> Seq.take 5 |> Dump