let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

let result = add x y
printf "%d" result //This will print 30

x <- 30
y <- 40

printf "%d" result // This will still print 30, demonstrating that the result is not updated automatically. 
