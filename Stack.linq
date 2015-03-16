<Query Kind="FSharpProgram" />

let create data =
    [data]
    
let push stack data =
    data :: stack
    
let pop stack =
    match stack with
    | x::xs -> x, xs
    
let st1 = create "zxcv" 
st1 |> Dump

let st2 = push st1 "qwer"
st2 |> Dump

let st3 = push st2 "vbnm"
st3 |> Dump

let el3, st4 = pop st3
el3 |> Dump
st4 |> Dump