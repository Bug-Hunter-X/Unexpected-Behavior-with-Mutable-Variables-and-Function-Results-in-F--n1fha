# F# Mutable Variable Bug

This repository demonstrates a common misunderstanding in F# regarding mutable variables and function results.  The `bug.fs` file shows code where a function's result does not automatically update when the input mutable variables change.  The `bugSolution.fs` file shows the corrected approach.

## Setup

1. Clone the repository.
2. Open the `.fs` files in an F# IDE (e.g., Visual Studio, Ionide).
3. Compile and run the code.

## Bug Description

Many developers coming from imperative languages might expect the result of a function to dynamically reflect changes to its mutable inputs.  This is not the case in F# unless the function is specifically designed to work that way using techniques like closures or references.

## Solution

The `bugSolution.fs` file demonstrates the correct approach, often involving recalculation whenever mutable values change. 