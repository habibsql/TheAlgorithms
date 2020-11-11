## Overview

![overview](https://github.com/habibsql/TheAlgorithms/blob/master/Src/TheAlgorithms/DynamicProgramming/ov.png?raw=true)

* Richard Bellman invent it 1950
* Solving complext problems by breaking them into simple subproblems.
* Problem can be devided into many smallest part.
* Many problems it is not possible to make stepwise decission in such a manner that the
sequence of decissions made is optimal.
* In Greedy method only one decission sequence is generated but dynamic programming
many decission sequences may be generated.
* Applicable when sub problems are not independent.
* Typically apply to optimiation problems

## Main Idea:
* Setup a recurrence relating a solution to a larger instance to solutions of some smaller instances.
* Solve smaller instances once.
* Record solutions in a table.
* Extract solutions to the inital instance from that table.

## Features:
* Easier to obtain the recurrence relation using backward approach.
* Often have polynomial complexity
* Optimal subproblems solution are retained so as to avoid recomputation.

## Difference between Divide and Conquer
Divide and Conquer | Dynamic Programming
Partitions a problem into independent smallest sub-problems | Partitions a problem into overlapping sub-problems
Does not store solutions of subproblems. So recomputation may happend | Store soluions of subproblems and avoid recomputation.
Topdown approach | Bottomup approach
