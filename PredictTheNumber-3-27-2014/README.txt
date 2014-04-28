Taken from: https://www.codeeval.com/open_challenges/125/

Predict the Number
Challenge Description:

Sequence 011212201220200112 ... constructed as follows: first is 0, then repeated the following action: already written part is attributed to the right with replacement 0 to 1, 1 to 2, 2 to 0. E.g.

0 -> 01 -> 0112 -> 01121220 -> ...

Create an algorithm which determines what number is on the N-th position in the sequence.
Input sample:

Your program should accept as its first argument a path to a filename. Each line in this file contains an integer N such as
0 <= N <= 3000000000. E.g.

0
5
101
25684

Output sample:

Print out the number which is on the N-th position in the sequence. E.g.

0
2
1
0

Submit your solution in a file (some file name).(py2| c| cpp| java| rb| pl| php| tcl| clj| js| scala| cs| m| py3| hs| go| bash| lua) or use the online editor.