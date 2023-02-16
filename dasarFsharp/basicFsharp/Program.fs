let random = System.Random()

let array = Array.init 10 (fun _ -> random.Next(1001))

let result = array |> Seq.filter (fun x -> x < 500) |> Seq.toArray

printfn "Result: %A" result
