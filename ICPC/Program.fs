module ICPC

open System
open System
open System.Runtime.InteropServices


let check (inp:char)=
    match System.Char.IsUpper(inp) with
    |true->true
    |_->false
let str (inp:string)=
   let sequ= inp|>Seq.map check|>Seq.contains(true)
   match sequ with
   |true->true
   |_->false

let errorCase4 (inp:string)=
    let rec ff (yi:string) i list=
       match i=yi.Length with 
       |false-> 
          match System.Char.IsLetter(yi.[i])||System.Char.IsWhiteSpace(yi.[i]) with
          |true->ff yi (i+1) (true::list)
          |_->
            match yi.[i]=',' with
            |true->
                match System.Char.IsWhiteSpace(yi.[i+1])&&System.Char.IsLetter(yi.[i+2])&&System.Char.IsLetter(yi.[i-1]) with
                |true ->ff yi (i+1) (true::list)
                |false->ff yi (i+1) (false::list)
            |false->
                match yi.[i]='.' with
                |true-> 
                    match yi.LastIndexOf('.')=i with
                    |true ->
                        match System.Char.IsLetter(yi.[i-1]) with
                        |true ->ff yi (i+1) (true::list)
                        |false->ff yi (i+1) (false::list)
                    |false->
                    match System.Char.IsWhiteSpace(yi.[i+1])&&System.Char.IsLetter(yi.[i-1])&&System.Char.IsLetter(yi.[i+2]) with
                     |true ->ff yi (i+1) (true::list)
                     |false->ff yi (i+1) (false::list)
                |false-> ff yi (i+1) (false::list)
       |_->list
    let sequ=ff inp 0 []|>List.toSeq|>Seq.contains(false)
    match sequ with
    |true->true
    |_->false

  
let commaSprinkler input =
    match input=""||input.Length=1||input.[0]=' '||input.[0]=',' ||input.[input.Length-1]<>'.'||input.Contains('?')||input.Contains('!')|| (str input)||(errorCase4 input) with 
    |true->None
    |_->Some input
    
(*let commaSprinkler (input:string) =
 match input.Length=0 || input.Length =1|| (errorCase4 input) with
 |true -> None
 |_-> match input.[0] = ' ' || input.[0] = ',' with
      |true-> None
      |_-> match input.[input.Length-1]='.' &&  Char.IsUpper(input.[input.Length-2]) || input.Contains('?') with
           |true -> None
           |_-> match input.[input.Length-1]='.' && input.[input.Length-1]<>' ' with
                |false-> None

                |true-> match input.Contains(',') || input.Contains("  ") || input.Contains(" ,") || input.Contains(" .") || input.Contains("...") || input.Contains(". .") with
                        |true -> None
                        |_-> Some input*)


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
