open System

let string_stuff() =
    // Escape characters
    // \n, \\, \", \'
    let str1 = "This is a random string"
 
    // Verbatim Strings
    let str2 = @"I ignore backslashes"
 
    // Triple Quoted Strings
    let str3 = """ "I ignore double quotes and backslashes" """
 
    // Combine strings
    let str4 = str1 + " " + str2
 
    // Get length
    printfn "Length : %i" (String.length str4)
 
    // Access index
    printfn"%c" str1.[1]  
 
    // Get a substring with a range
    printfn"1st Word : %s" (str1.[0..3])
 
    // Collect executes a function on each character
    let upper_str = String.collect (fun c -> sprintf"%c, " c) "commas"
    printfn "Commas : %s" upper_str
 
    // Exists checks if any characters meet a condition
    printfn "Any Upper : %b" (String.exists (fun c -> Char.IsUpper(c)) str1)
 
    // Check if every character meets condition
    printfn "Number : %b" (String.forall (fun c -> Char.IsDigit(c)) "1234")
 
    // Apply function to each index in a string
    let string1 = String.init 10 (fun i -> i.ToString())  
    printfn"Numbers : %s" string1
 
    // Apply function to each item in string
    String.iter(fun c -> printfn "%c" c) "Print Me" 

string_stuff()