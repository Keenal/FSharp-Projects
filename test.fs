let prefix string1 string2 = 
    string1 + ", " + string2

let names = ["dfafd"; "dfsaf"; "dsf"]

let prefixWithHello = prefix "Hello"

let exclaim s = s + "!"

let bigHello = prefixWithHello >> exclaim

let hellos = 
    names
    |> Seq.map (fun x -> printfn "Mapped with %s" x; bigHello x)
    |> Seq.sort
    |> Seq.iter (printfn "%s")

hellos
