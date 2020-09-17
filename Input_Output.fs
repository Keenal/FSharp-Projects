// Allows you access to ReadLine, WriteLine, etc.
open System
 
// ----- INTRODUCTION -----
 
// Let binds a name to a value or function
let hello() = 
 
    // Print to screen without a newline
    printf "Enter your name : "
 
    // Read data from the user
    // Identifiers must start with an underscore
    // or a letter and then numbers
    let name = Console.ReadLine()
 
    // printfn is statically typed in regards
    // to the parameters %s represents a string
    // %i : Integer
    // %f : float
    // %b : boolean
    // %s : string
    // %A : Internal representation of things like tuples
    // %O : Other objects
    printfn "Hello %s" name
 
    // Format floats which default to 6 digits 
    printfn "PI : %.4f" 3.141592653589793238462643383
 
    // Use M to keep precision to 27 decimals
    let big_pi = 3.141592653589793238462643383M
 
    printfn "Big PI : %M" big_pi
 
    // Add padding to right and left
    printfn "%-5s %5s" "a" "b"
 
    // Add dynamic padding
    printfn "%*s" 10 "Hi"

hello()
