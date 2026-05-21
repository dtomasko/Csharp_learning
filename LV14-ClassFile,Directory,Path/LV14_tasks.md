[ Previous](../LV13-List_ArrayList/LV13_tasks.md) | [ Home](../README.md) | [Next ](../LV15-Exam03/LV15-tasks.md)

---

# Exercise 14: File, Directory & Path

## Task 14.1

Write a program that copies the contents of `source.txt` to `destination.txt`. The program should check whether the files exist and handle potential errors during copying.

## Task 14.2

Write a program that uses `StreamReader` to read the contents of the file `text.txt`. The program should:

- Print all lines from the file to the screen.
- If the file does not exist, print the message "File does not exist.".
- If the file contains more than 100 lines, print only the first 100 lines.

## Task 14.3

Write a program that uses `StreamWriter` to write data to the file `log.txt`. The program should:

- Write the date and time the program was run to the file.
- Write information about each user input (for example, each time the user types text).
- If `log.txt` already exists, append the new data to the end of the file rather than overwriting the existing contents.

## Task 14.4

Solve task 14.2 using the `File` class instead.

## Task 14.5

Solve task 14.3 using the `File` class instead.

## Task 14.6

Write a program that searches a directory and its subdirectories, and prints all files with the extension `.txt`. The program should use recursion to visit subdirectories.

## Task 14.7

Write a program that moves all `.jpg` files from the directory `source_directory` to `destination_directory`. The program should check whether both directories exist and handle errors during the move.

## Task 14.8

Write a program that takes a user-entered file path and prints the absolute path, file name, and file extension using the `Path` class.

## Task 14.9

Write a program that checks whether the entered path is a directory or a file using `Path.GetExtension()`, and prints an appropriate message.

## Task 14.10

Write a program that saves 100 random numbers from 0 to 1 in the file `random_numbers.txt`. The program should save the file in the `CSharp` directory, creating that directory if it does not already exist. If `random_numbers.txt` already exists, move the old file to the `Temp` subfolder and rename it to `slucani_brojevi_staro.txt`. The program should create the `Temp` subdirectory only if it does not already exist.

Note: Use the `Random` class to generate random numbers. The `NextDouble()` method returns a random number between 0 and 1, while `Next()` returns a random integer. When using `Next(min, max)`, the first argument is the inclusive lower limit and the second is the exclusive upper limit.

## Task 14.11

Write a program that asks for the user's name, then creates a directory with that name on the desktop (checking whether the directory already exists). In that directory, create a file named `<name>.txt` (checking whether the file already exists). Prompt the user to enter the names of 5 students in the class and write each name into the file on a separate line. Finally, print only the 2nd and 4th names from the file to the screen.

If the file already exists, move it to a `temp` subdirectory (checking whether the subdirectory already exists) and add today's date to the file name to avoid deleting the existing file.

## Task 14.12

Write a program that encrypts the contents of a text file using the simple Rot13 algorithm and saves the result to another file. Search the Internet to learn how the Rot13 algorithm works.

---

[ Previous](../LV13-List_ArrayList/LV13_tasks.md) | [ Home](../README.md) | [Next ](../LV15-Exam03/LV15-tasks.md)
