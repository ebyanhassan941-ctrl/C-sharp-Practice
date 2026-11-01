# Chapter 4 — Files, Dialogs, Random Numbers and the Load Event

**Textbook:** Starting Out with Visual C# (6th Edition) by Tony Gaddis
**Scope:** Slides 21 to 42 (continues from the Loops README)

> Add `using System.IO;` at the top of your form to use `File`, `StreamWriter` and `StreamReader`.

---

##  Table of Contents

1. [Using Files for Data Storage](#1-using-files-for-data-storage)
2. [File Accessing: StreamWriter and StreamReader](#2-file-accessing-streamwriter-and-streamreader)
3. [Writing Data to a File](#3-writing-data-to-a-file)
4. [CreateText vs AppendText](#4-createtext-vs-appendtext)
5. [Specifying the Location of a File](#5-specifying-the-location-of-a-file)
6. [Reading Data from a File](#6-reading-data-from-a-file)
7. [Reading a File with a Loop](#7-reading-a-file-with-a-loop)
8. [OpenFileDialog and SaveFileDialog](#8-openfiledialog-and-savefiledialog)
9. [Detecting the User's Selection](#9-detecting-the-users-selection)
10. [FileName and InitialDirectory](#10-filename-and-initialdirectory)
11. [SaveFileDialog](#11-savefiledialog)
12. [Random Numbers](#12-random-numbers)
13. [The Load Event](#13-the-load-event)
14. [Quick Summary](#-quick-summary)

---

## 1. Using Files for Data Storage

When a program needs to save data for later use, it writes the data to a **file**.

**There are always three steps:**

| Step | Description |
|:-:|---|
| 1. **Open** | Create a connection between the file and the program |
| 2. **Process** | Write to the file or read from it |
| 3. **Close** | Disconnect the file and the program |

**Two types of files:**

| Type | Description |
|---|---|
| **Text file** | Data encoded as text (for example Unicode). Can be opened in a text editor |
| **Binary file** | Data not converted to text. Cannot be viewed in a text editor |

> This chapter works only with **text files**.

---

## 2. File Accessing: StreamWriter and StreamReader

A **file object** is an object associated with a specific file. It gives the program a way to work with that file.

.NET provides two classes:

| Class | Purpose |
|---|---|
| `StreamWriter` | **Writes** data to a text file |
| `StreamReader` | **Reads** data from a text file |

---

## 3. Writing Data to a File

**Steps:**
1. Create a `StreamWriter` object.
2. Open the file using a File method: `File.CreateText` or `File.AppendText`.
3. Write data with `Write` or `WriteLine`.
4. **Close** the connection.

**Code:**

StreamWriter outputFile;  
outputFile = File.CreateText("courses.txt");  
outputFile.WriteLine("Introduction to Computer Science");  
outputFile.WriteLine("English Composition");  
outputFile.WriteLine("Calculus I");  
outputFile.Close();  

| Method | Behavior |
|---|---|
| `WriteLine` | Writes the item, then a **newline** (end of line) |
| `Write` | Writes the item **without** a newline |

---

## 4. CreateText vs AppendText

| Method | What it does |
|---|---|
| `File.CreateText` | Creates a new text file. If the file already exists, its contents are **erased** |
| `File.AppendText` | Opens the file and **adds** to the end, keeping the existing contents |

`CreateText` also creates a `StreamWriter` object in memory, associated with the file, and returns a reference to it.

**AppendText example:**

StreamWriter outputFile;  
outputFile = File.AppendText("Names.txt");  
outputFile.WriteLine("Lynn");  
outputFile.WriteLine("Jamal");  
outputFile.WriteLine("Alex");  
outputFile.Close();  

---

## 5. Specifying the Location of a File

To open a file in a different location, include the **path** along with the file name.

 Put the **@** character before the string so that backslashes are read correctly.

StreamWriter outputFile = File.AppendText(@"C:\Data\Names.txt");  

Without `@`, each backslash must be doubled:

outputFile = File.CreateText("D:\\C#\\Project\\Names.txt");  

---

## 6. Reading Data from a File

**Steps:**
1. Create a `StreamReader` object.
2. Open the file with `File.OpenText`.
3. Read data with `Read`, `ReadLine`, etc.
4. **Close** the connection.

**Code:**

StreamReader inputFile;  
inputFile = File.OpenText("students.txt");  
&nbsp;  
string line = inputFile.ReadLine();  
&nbsp;  
inputFile.Close();  

| Method | What it does |
|---|---|
| `StreamReader.ReadLine` | Reads **one line** and returns it as a string |
| `StreamReader.Read` | Reads the **next character** from the input stream |
| `StreamReader.ReadToEnd` | Reads **everything** from the current position to the end of the file as one string |
| `File.ReadAllText(path)` | Opens the file, reads **all** its text as one string, and closes it |

---

## 7. Reading a File with a Loop

`StreamReader` has a Boolean property named **`EndOfStream`** that signals whether the end of the file has been reached.

while (inputFile.EndOfStream == false)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;// read and process one line  
}  

Or the shorter form:

while (!inputFile.EndOfStream)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;// read and process one line  
}  

**Full example: show every line in a ListBox:**

StreamReader inputFile = File.OpenText("courses.txt");  
&nbsp;  
while (!inputFile.EndOfStream)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;string line = inputFile.ReadLine();  
&nbsp;&nbsp;&nbsp;&nbsp;coursesListBox.Items.Add(line);  
}  
&nbsp;  
inputFile.Close();  

---

## 8. OpenFileDialog and SaveFileDialog

These controls let your application show the **standard Windows dialog boxes** for opening and saving files.

| Control | Dialog it displays |
|---|---|
| `OpenFileDialog` | The standard Windows **Open** dialog box |
| `SaveFileDialog` | The standard Windows **Save As** dialog box |

- Unlike Label, Button and TextBox, they are **invisible controls**.
- When added to the form, they appear in the **component tray** at the bottom of the Designer, not on the form.

**Displaying the Open dialog:**

private void openButton_Click(object sender, EventArgs e)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;openFileDialog.ShowDialog();  
}  

---

## 9. Detecting the User's Selection

`ShowDialog` returns a **DialogResult** value that tells which button the user clicked.

| Button clicked | Value returned |
|---|---|
| Open (or Save) | `DialogResult.OK` |
| Cancel | `DialogResult.Cancel` |

DialogResult result = openFileDialog.ShowDialog();  
&nbsp;  
if (result == DialogResult.OK)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;// the user clicked Open  
}  
else if (result == DialogResult.Cancel)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;// the user clicked Cancel  
}  

---

## 10. FileName and InitialDirectory

- After the user picks a file, its **path and file name** are stored in the control's **`FileName`** property.
- **`InitialDirectory`** sets the folder shown first when the dialog opens.

openFileDialog.InitialDirectory = @"C:\Data";  
&nbsp;  
if (openFileDialog.ShowDialog() == DialogResult.OK)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;inputFile = File.OpenText(openFileDialog.FileName);  
}  

---

## 11. SaveFileDialog

Works the same way as `OpenFileDialog`:

if (saveFileDialog.ShowDialog() == DialogResult.OK)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;outputFile = File.CreateText(saveFileDialog.FileName);  
&nbsp;&nbsp;&nbsp;&nbsp;outputFile.WriteLine(resultTextBox.Text);  
&nbsp;&nbsp;&nbsp;&nbsp;outputFile.Close();  
}  

---

## 12. Random Numbers

.NET provides the **Random** class to generate random numbers.

**Create a Random object:**

Random rand = new Random();  

| Method | What it returns |
|---|---|
| `Next()` | A random **integer** from 0 to 2,147,483,647 |
| `NextDouble()` | A random **floating-point** number from 0.0 up to (but not including) 1.0 |

int number1 = rand.Next();  
double number2 = rand.NextDouble();  

**A random number from 0 to some other limit:**

`RandomObject.Next(max + 1)`: the upper limit is **exclusive**, so add 1 to include your maximum.

int number = rand.Next(100);    // 0 to 99  
int dice = rand.Next(6) + 1;    // 1 to 6  

---

## 13. The Load Event

When an application runs, its form is **loaded into memory** and an event named **Load** occurs.

**To create a Load event handler:** double-click the form in the Designer.

private void Form1_Load(object sender, EventArgs e)  
{  
&nbsp;  
}  

Any code inside the Load event runs **when the form is launched**:

private void Form1_Load(object sender, EventArgs e)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show("Prepare to see the form!");  
}  

---

## Quick Summary

| Topic | Key idea |
|---|---|
| Three file steps | Open, Process, Close |
| `StreamWriter` | Write text to a file |
| `StreamReader` | Read text from a file |
| `File.CreateText` | New file (erases old contents) |
| `File.AppendText` | Add to the end of a file |
| `File.OpenText` | Open a file for reading |
| `EndOfStream` | Tells when the end of the file is reached |
| `OpenFileDialog` / `SaveFileDialog` | Standard Open / Save As windows |
| `DialogResult.OK` / `.Cancel` | Which button the user clicked |
| `FileName` | Path of the chosen file |
| `Random.Next(n)` | Random integer from 0 to n – 1 |
| `Form_Load` | Code that runs when the form starts |

---

*Source: Gaddis, Starting Out with Visual C#, 6e, Pearson Education. Chapter 4 slides 21–42.*