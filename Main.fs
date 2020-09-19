#time "on"
#r "nuget: Akka.FSharp" 
#r "nuget: Akka.TestKit" 
// #load "Bootstrap.fsx"

open System
open Akka.Actor
open Akka.Configuration
open Akka.FSharp

let system = System.create "MySystem" (Configuration.defaultConfig())


let bigint (x:int) = bigint(x)
let n=500 
let k=2 

let check message = 
    //printfn "Hello%i " message
    let mutable res=0 |> bigint
    let mutable msg = message |> bigint
    let mutable k2 = k |> bigint
    let mutable i=msg
    let mutable increment = 1 |> bigint
    //i |> bigint
    //printfn "Type message : %A" (msg.GetType())
    //printfn "Type k2 : %A" (k2.GetType())
    //printfn "Type n : %A" (n.GetType())
    //printfn "Type : %A" (i.GetType())
   // printfn "Type res : %A" (res.GetType())
    while (i<(msg+k2)) do
        res <- res+ (i*i)
        i<- i + increment

   // for i=message |> bigint to (message+k-1) |> bigint do
        //printfn "result= %i" res

    

    let root= sqrt (float res) 
    ()
    //()
    //if message = 46564 then
        //printfn "result= %i" res
        //printfn "root :%f" root
   // printfn "root :%f" root
    //printfn "Type ROOT : %A" (root.GetType())

    if root % 1.000000 = 0.000000 then
        printfn "Perfect Square: %i" message
         



let myActor (mailbox: Actor<_>) = 
    actor {
        let rand = System.Random()
        printf "HERE   "
        let! message = mailbox.Receive()
        let sender = mailbox.Sender()
        match message with 
        | _ -> check message
        sender <! message
    }

let myMonitor (mailbox: Actor<_>) =
    let mutable i = 11
    let actorArray = Array.create (11) (spawn system "myActor" myActor)
    {1..10} |> Seq.iter (fun a ->
        actorArray.[a] <- spawn system (string a) myActor
        ()
    )
   


    // First group
    //{1..10} |> Seq.iter(fun a ->
     //   actorArray.[a] <! a 
    //    ()
   // )

    let comp=n/10
    let mutable b = 1
    for i=1 to 10 do
        for k=b to (b+comp) do
            actorArray.[i] <! b  
            //printf "b=%i" b
            b<-b+1

    let rec loop() =
        actor {
            let! message = mailbox.Receive()
            match message with
            |_ -> 
                //actorArray.[message] <! i  
               // i<-i+1 
            
             
              
            return! loop()
        } 
    loop()

let mon = spawn system "myMon" myMonitor