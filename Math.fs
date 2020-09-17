// ----- MATH -----
let do_math() =
    printfn "5 + 4 = %i" (5 + 4)
    printfn "5 - 4 = %i" (5 - 4)
    printfn "5 * 4 = %i" (5 * 4)
    printfn "5 / 4 = %i" (5 / 4)
    printfn "5 %% 4 = %i" (5 % 4)
    printfn "5 ** 2 = %f" (5.0 ** 2.0)
 
    // Get the data type
    let number = 2
    printfn "Type : %A" (number.GetType())
 
    // Cast to another type
    printfn "A Float : %.2f" (float number)
    printfn "An Int : %i" (int 3.14)
 
    // Math functions
    // Also cos, sin, tan, acos, asin, atan,
    // cosh, sinh, tanh
    printfn "abs 4.5 : %i" (abs -1)
    printfn "ceil 4.5 : %f" (ceil 4.5)
    printfn "floor 4.5 : %f" (floor 4.5)
    printfn "log 2.71828 : %f" (log 2.71828)
    printfn "log10 1000 : %f" (log10 1000.0)
    printfn "sqrt 25 : %f" (sqrt 25.0)

do_math()