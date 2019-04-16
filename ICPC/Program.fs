module ICPC

open System

let check (inp:char)=
    match System.Char.IsUpper(inp) with
    |true->true
    |_->false
let str (inp:string)=
   let sequ= inp|>Seq.map check|>Seq.contains(true)
   match sequ with
   |true->true
   |_->false
let commaSprinkler input =
    match input=""||input.Length=1||input.[0]=' '||input.[0]=',' ||input.[input.Length-1]<>'.'||input.Contains('?')||input.Contains('!')|| (str input) with 
    |true->None
    |_->Some input
    
let numOfWords (inp:string)= 
    let s=inp.Trim()
    match s=inp with 
    |false->false
    |_->  

        let s=inp.Split(' ')
        match s.Length>=2 with
        |true->true
        |_->false

let rivers input =
    match input<>"" && numOfWords input=true with
    |true-> Some input
    |_->None

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
