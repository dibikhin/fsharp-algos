let sumOfMult nums divisors =
	let dividedOk dividend =
		divisors
		|> Seq.exists (fun x -> dividend % x = 0)
	nums
	|> Seq.where dividedOk
	|> Seq.sum

sumOfMult [1..999] [3;5] |> Dump // -> 233168
