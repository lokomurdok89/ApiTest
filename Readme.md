# :first_quarter_moon: Arithmetic Expressions in NET 7 In VSCode

## :octocat: Explicación de intención del proyecto

[Lokomurdok89 en Github](https://github.com/okomurdok89)

5-year-old Shinchan had just started learning mathematics. Meanwhile, one of his studious classmates,
Kazama, had already written a basic calculator which supports only three operations on integers:
multiplication , addition , and subtraction . Since he had just learned about these operations,
he didn't know about operator precedence, and so, in his calculator, all operators had the same
precedence and were left-associative.
As always, Shinchan started to irritate him with his silly questions. He gave Kazama a list of integers
and asked him to insert one of the above operators between each pair of consecutive integers such that
the result obtained after feeding the resulting expression in Kazama's calculator is divisible by 101. At his
core, Shinchan is actually a good guy, so he only gave lists of integers for which an answer exists.
Can you help Kazama create the required expression? If multiple solutions exist, print any one of them.

## :metal: Input Format

The first line contains a single integer "N" denoting the number of elements in the list. The second line
contains "N" space-separated integers "a1,a2,...,aN" dneoting the elements of the list.

### :rocket: Constraint

* [X] 2 < N <= 10^4  
* [X] 1 <= ai <= 100 
* [X] The length of the output expression should not exceed 10n

## :sparkles: Output Format
* [X] You are not allowed to permute the list.
* [X] All operators have the same precedence and are left-associative, e.g.,  a + b x -d x e is interpreted as (((( a + b) x c) -d) x e)
* [X] Unary plus and minus are not supported, e.g., statements like ,-a,a X -b ,-a x b +c or are invalid.

## :+1: Sample Input 0
```javascript
3
22 79 21
```
## :+1: Sample Otput 0
```javascript
22*79-21
Solution 1: 22 x 79 -21 = 1717 / 101 = 17, where , so it is perfectly divisible by 101.
Solution 2: 22 + 79 x 21 = 2121 which is also divisible by 101.
```
