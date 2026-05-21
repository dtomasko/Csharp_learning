[ Previous](../LV14-ClassFile,Directory,Path/LV14_tasks.md) | [ Home](../README.md)

---

# Exercise 15: Exam 03

## Task 15.1

Write a program that asks the user to enter a directory path. If the directory does not exist, create it and create a `Temp` subdirectory inside it. If the directory already exists, delete it.

## Task 15.2

Write a program that asks the user to enter the path to a folder. If the folder exists, print all files and subfolders within it (first level only). Then ask the user to enter the path to another folder. Move all `.txt` files from the first folder to the second using `File.Move`. If a file already exists in the destination folder, do not move it and print a message.

## Task 15.3

Write a program that asks for the path of a file on the desktop. If the file exists, print the third line of text from the file to the screen. If the file does not exist, create it and write:

- "I'm going to the beach."
- "I'm going to program on the beach."
- "Ivan"

## Task 15.4

Write a program that writes `n` integers to the file `numbers.txt`. Ask the user to enter the number `n` and then enter the integers from the keyboard. Validate the input and re-prompt if necessary. Read the data from `numbers.txt` (do not create an auxiliary string while entering integers or immediately check for divisibility by 3), then write to the file `dijeliviS3.txt` how many numbers in `numbers.txt` are divisible by 3. Print the contents of both `numbers.txt` and `dijeliviS3.txt`.

## Task 15.5

Write a program that calculates your current age after entering your birthdate. Use `DateTime` and `TimeSpan` methods and print the number of years.

## Task 15.6

Write a program that, after entering a string and an integer `n`, converts the first letter of the string to lowercase. Use `String` class methods and print the resulting string.

## Task 15.7

Write a program that asks for elements in an `ArrayList` until the user types a space. Create two lists, `List<string>` and `List<double>`, and transfer all elements from the first list into them according to their type. Print both lists.

## Task 15.8

Write a program that asks for text input from the keyboard and writes the text to the file `text.txt`. Before creating the file, check whether `text.txt` exists. If it does, move it to the `temp` folder that the program will create. Then print the text from `text.txt` with the order of lines reversed (the first becomes the last, the second becomes the second to last, etc.).

---

[ Previous](../LV14-ClassFile,Directory,Path/LV14_tasks.md) | [ Home](../README.md)
