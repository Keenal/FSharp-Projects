type Details = 
    { Name: string
    Description: string }

type Exits = 
    { North: Exit 
      South: Exit 
      East : Exit 
      West : Exit }
      
type Room = 
   { Details: Details }