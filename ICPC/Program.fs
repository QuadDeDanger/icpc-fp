module ICPC
open System
open System

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
