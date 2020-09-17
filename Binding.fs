// ----- BINDING -----
let bind_stuff() =
    
    // By default variables are immutable
    // unless marked as mutable
    let mutable weight = 175
    weight <- 170
 
    printfn "weight : %i" weight
 
    // You can also use reference cells if you
    // must change values
    let change_me = ref 10
    change_me := 50
 
    printfn "change_me : %i" ! change_me

bind_stuff()