let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

let mutable result = add x y
printf "%d" result //This will print 30

x <- 30
y <- 40

result <- add x y // Recalculate result to reflect changes
printf "%d" result // Now this will print 70

//Alternative using a function that returns a function that closes over the mutable variables
let createAdder() = 
    let mutable x = 10
    let mutable y = 20
    fun () -> x + y

let adder = createAdder()
printf "%d %d" (adder()) (adder()) //Prints 20 20

x <- 30
y <- 40
printf "%d %d" (adder()) (adder()) //Prints 70 70