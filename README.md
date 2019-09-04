# CollectionsHomework
## Homework Instructions
Lab 1 : Cubic Array 10x10x10

Build a three dimensional array and populate it with numbers which are products of the input numbers. Make the size of the cube to be 10x10x10 and your numbers will run from 1 at (1,1,1) through 1000 at (10,10,10). Numbering starts at 1 here instead of 0.

Tip : use a loop within a loop within a loop to accomplish this!

Finally output the value at (2,3,7) and check it has value 2x3x7=42

Lab 2 : List

Create a one-dimensional list of integers called List01.

Iterate over the three dimensional array above, and for every number in the array, add it to the list.

Finally add up the total sum of all numbers in the list and output the result.

Lab 3 : Dictionary

Create a dictionary of 10 countries as the index, with the capital city as the data.

Iterate over the data and display it.

Return the completed dictionary to complete the test

Lab 4 : Queue

Count from 1 to 100 and add the cubes of each number to a queue.

Run dequeue 10 times and sum the output

Return this sum.

Lab 5 : Stack

Repeat this for a stack ie count from 1 to 100, add the cube of each number to the stack, then pop 10 items off the top of the stack and sum the output of those 10 numbers.

Return this sum

## Implementation
Lab 1: To populate the cubic array three nested for loops were used.

Since arrays begin counting from index zero a +1 was used to have the array begin counting from a value of 1.

Lab 2: A for each was used to populate the list, iterating through each value in the array. During each iteration the current array value was added to the sum.

Lab 3: Declared and populated a dictionary called countryCapital and used a for each loop to write each pair value to console

Lab 4: Declared a queue called cubeQueue and used a for loop counting from 1 to 100 to add the product to the queue.

10 values were dequeued using a for loop and totaled to calculate the sum.

Lab 5: Declared a stack called cubeStack and repeated the same steps as Lab 4 but instead using Push to add values to the stack and Pop to remove values.
