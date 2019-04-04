module ICPC
open System
open System

let commaSprinkler input =
 let INPUT = [|input|]
 //let x = input.Split []
 match input="" || input.Length=1 || input=" _" || INPUT.[0]=" "|| INPUT.[0]=","  with
  |true -> None
  |_->Some input(*_-> match input.Split(" ") with
       | -> Some " "
       |*)

let rivers (input:string) =
 let x= input.Split( ',' , StringSplitOptions.None);
 let space = input.Split [|' '|]
 let i=input.Split[|'!'|]
 let j=input.Split[|','|]
 let liiiiist= [input]
 match x with 
  |[| "" |]-> None
  |[| _ |] -> match space.Length < 1 with
              |true -> None
              |_->Some input.Length

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
