# Files Reading and Delete (C# Windows Forms)

This Assignment shows how to *write, **read, and **delete* a file (index.txt) in C# using the StreamWriter, StreamReader, and File classes.

## Screenshot 1: Writing the File (StreamWriter)

![Screenshot 1](screenshot\Create_file.png)

Here we use *StreamWriter* to create a new file called index.txt.

- StreamWriter outputFile; declares the object used for writing.
- File.CreateText() creates the new file and connects the program to it.
- WriteLine() writes data into the file, one line at a time.
- Close() closes the file once writing is finished.

## Screenshot 2: Reading the File (StreamReader and ReadAllLines)

![Screenshot 2](screenshot\Reading_file.png)

Here we use *StreamReader* to read the file.

- StreamReader reader; declares the object used for reading.
- We use the *File.ReadAllLines()* function, which reads the file as an *array*, with each line as one element.
- A *foreach loop* then goes through each line and displays it in listDisplay.

## Screenshot 3: Deleting the File

![Screenshot 3](screenshot\Deleting_file.png)

Here we use *File.Delete()* to delete the file by its *file name* (index.txt).

- File.Exists() first checks that the file exists.
- File.Delete() removes the file if it exists.

## Conclusion

In this project we learned how to work with files in C#. We learned that StreamWriter and File.CreateText() are used to *write* a new file, StreamReader and File.ReadAllLines() are used to *read* it, a foreach loop displays the data in an organized way, and File.Delete() *deletes* the file. We also learned how important it is to check the path and use File.Exists() to avoid errors such as Illegal characters in path, and to always close the file (Close()) when finished.