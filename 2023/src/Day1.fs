module _2023_AoC.src.Day1

open System

let inverseResult fn =
    fun value -> not (fn value)
    
let convertCharDigitsToInt digitsAsChars =
    digitsAsChars |>
        Seq.map (fun c -> int (string c))

let firstAndLast numbers =
    (Seq.head numbers, Seq.last numbers)
        
let run (input: string) =
    input.Split '\n'
        |> Seq.map (Seq.filter System.Char.IsDigit)
        |> Seq.filter (inverseResult Seq.isEmpty)
        |> Seq.map convertCharDigitsToInt
        |> Seq.map firstAndLast
        |> Seq.map (fun numbers -> (fst numbers) * 10 + snd numbers)
        |> Seq.sum
    
    

