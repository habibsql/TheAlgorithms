## Overview:

![overview](https://github.com/habibsql/TheAlgorithms/blob/main/Src/TheAlgorithms/Greedy/flow.JPG?raw=true)

* Prefer shortterm view over long term view, which sometimes work sometimes counter productive.
* Simple type of stratigy 
	* Take a step that makes the problem smaller.
	* Iterate
* Difficult to get the optimal solution.
* Examples: Halfman code
* Locally optimal choice at each stage with the hope(local optimum choise will lead global optimum) 
of finding global optimum.
* Some optimization problems, dynamic programming is overkill. Greedy is simpler and more efficient there.

## Example: 
** Input1: currency {1, 2, 5, 10, 50, 100, 500, 100}
** Input2: 70
** Output: 2 ( Note 50 + Note 20)

## Properties:
** Greedy choice property: A global optimum can be arrived at by selecting a local optimum.
** Optimal Substructure: A optimal solution to the problem contains to the optimal solution to subproblems.

## Applications:
* Minimum Spaning Tree
* Huyffman Coding
* Traveling Sales Problem
* Knapsack Problem
* Optimal Merging

## Advantages
* Simple
* Easy to Implement.
* Fast

## Drawback
* Very often do not provide global optimum solution.
* Hard to verify that is really optimum or not.

## Difference between Dynamic Programming and Greedy
Dynamic Programming | Greedy
Each step the solution is determined based on solutions of subprograms | Quickly make a choose currentlylooks best.
Bootomup approach | Top-Down approach
Slower | Faster
Complex | Simpler

## Charecterristics
* Make a sequence of choices.
* Each choice is one that looks best so far.
* Choice procedures a smaller problem to be solved.
