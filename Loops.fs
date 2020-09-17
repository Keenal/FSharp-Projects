open System

let loop_stuff() =
 
    // ----- WHILE LOOP -----
    let magic_num  = "7"
    let mutable guess = ""
 
    while not (magic_num.Equals(guess)) do
        printf "Guess the Number : "
        guess <- Console.ReadLine()
 
    printfn "You Guessed the Number"


loop_stuff()

let for_loop() = 
    // ----- FOR LOOP -----
    for i = 1 to 10 do 
        printfn "%i" i
 
    // Iterate down
    for i = 10 downto 1 do
        printfn "%i" i
 
    // Iterate over a range
    for i in [1..10] do
        printfn "%i" i
 
    // Why loop at all when you can pipe a list to any function
    [1..10] |> List.iter (printfn "Num : %i")
 
    // Sum a list
    let sum = List.reduce (+) [1..10]
    printfn "Sum : %i" sum

for_loop()

Console.ReadKey() |> ignore