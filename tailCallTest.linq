<Query Kind="FSharpProgram" />

let rec loopAndSum aList sumSoFar =
	match aList with
	| [] -> sumSoFar
	| x::xs -> loopAndSum xs (sumSoFar + x)
	
loopAndSum [1..5] 0 |> Dump

// non-tail-recursive due to lack of parens in the end
//let rec loopAndSum aList sumSoFar =
//	match aList with
//	| [] -> sumSoFar
//	| x::xs -> loopAndSum xs sumSoFar + x