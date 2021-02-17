let sumOfEvenFibsLessThan limit =
	let rec fib first second =
		seq {
			yield first
			yield! fib (first + second) first }
		
	fib 0 1
	|> Seq.where (fun x -> x % 2 = 0 )
	|> Seq.takeWhile (fun x -> x <= limit)
	|> Seq.sum

sumOfEvenFibsLessThan 4000000 |> Dump // -> 4613732
