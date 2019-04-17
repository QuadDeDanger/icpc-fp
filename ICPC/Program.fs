module ICPC

open System
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

(*let checkInput (inp:string)=
    let rec sentence (input:string) counter =
     match counter>=input.Length with
     |true->true
     |_-> 
        match input[counter]='.'&& counter<>(input.Length-1) with
        |true->*)
(*let commaSprinkler input =
    match input=""||input.Length=1||input.[0]=' '||input.[0]=',' ||input.[input.Length-1]<>'.'||input.Contains('?')||input.Contains('!')|| (str input) with 
    |true->None
    |_->Some input*)
    
let numOfWords (inp:string)= 
    let s=inp.Trim()
    match s=inp with 
    |false->false
    |_->  

        let s=inp.Split(' ')
        match s.Length>=2 with
        |true->true
        |_->false


let commaSprinkler (input:string) =
 let INPUT = [|input|]
 match input.Length=0 || input.Length =1 with
 |true -> None
 |_-> match input.[0] = ' ' || input.[0] = ',' with
      |true-> None
      |_-> match input.[input.Length-1]='.' &&  Char.IsUpper(input.[input.Length-2]) || input.Contains('?') with
           |true -> None
           |_-> match input.[input.Length-1]='.' && input.[input.Length-1]<>' ' with
                |false-> None
                |true-> match input.Contains(',') || input.Contains("  ") || input.Contains(" ,") || input.Contains(" .") || input.Contains("...") || input.Contains(". .") with
                        |true -> None
                        |_-> Some input


let rivers (input:string) =
 //let space = input.Split(' ')
  match input.Length=0 with
  |true -> None
  |false->
         match input.Length<>0 || input.Contains('!') || input.Contains(',') || input.[input.Length-1]= ' ' || input.[0] = ' ' with
         |true -> None
         |_-> match  input.Contains(' ') with
              |false-> None
              |true -> Some input.Length 



[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
