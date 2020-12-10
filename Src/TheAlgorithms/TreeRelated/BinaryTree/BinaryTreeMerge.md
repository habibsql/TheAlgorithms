# 2 Binary Tree Merge

#### Problem:
Given 2 binary trees and need to merge them and create a new binary tree.

* Rule1: if 2 nodes are overlap then do sum of them.
* Rule2: if one of them is null then not null node will be used.

##### Example:

```
Input: 
	Tree 1                     Tree 2                  
          1                         2                             
         / \                       / \                            
        3   2                     1   3                        
       /                           \   \                      
      5                             4   7        


Output: 
Merged tree:
	     3
	    / \
	   4   5
	  / \   \ 
	 5   4   7

```

