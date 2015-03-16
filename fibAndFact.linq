<Query Kind="FSharpProgram" />

// both fib & fact are tail recursive

let rec sum acc = function
	| 0 -> acc
	| i -> sum (acc + i) (i - 1)

sum 0 5 |> Dump

let rec fact acc = function
	| 0 -> acc
	| i -> fact (acc * i) (i - 1)

fact 1 5 |> Dump

let rec factNotTail = function
    | n when n < 1 -> 1
    | n -> factNotTail (n - 1) * n
	
factNotTail 5 |> Dump