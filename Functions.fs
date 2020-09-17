// ----- FUNCTIONS -----
// Functions start with let, the name, parameters, 
// optional parameter types, optional return type

open System

let do_sum() = 
    let get_sum (x : int, y : int) : int = x + y

    printfn "%i %i = %i" 5 7 (get_sum(5,7))

do_sum()

// Calculate the factorial with a recursive function
let fact() = 
    let rec factorial x = 
        if x < 1 then 1
        else x * factorial (x - 1)

    printfn "Factorial of %i: %i" 4 (factorial 4)

fact()

// We use fun to create lambda expressions
let lamb() = 
    let rand_list = [1;2;3]
    let rand_list2 = List.map(fun x -> x * 2) rand_list // Map performs a calculation on every item in the list and returns the new list

    printfn "result : %A" rand_list2 // %A returns the internal representation of a list

    // using the pipe operator
    [1;2;3]
    |> List.map(fun x -> x * 2) 
    |> printfn "sdf %A"

    [5;6;7;8]
 
    // Filter keeps only items in the list that 
    // match the condition
    |> List.filter (fun v -> (v % 2) = 0)
    |> List.map (fun x -> x * 2)
 
    // Once the list has been created print it
    |> printfn "Even Doubles : %A"

lamb()

let exeFunc() = 
    let mult x = x * 3
    let add y = y + 5

    let mult = mult >> add
    let add = add << mult

    printfn "mult : %i" (mult 10)
    printfn "add : %i" (add 10)

exeFunc()







