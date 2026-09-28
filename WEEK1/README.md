# introduction to C#

## Topics
-1.1 Objects <br>
-1.2 The Program Development Process <br>
-1.8 Getting Started with Visual Studio <br>
-2.1 Getting Started with Forms and Controls <br>
-2.2 Creating the G U I for Your First Visual C# Application <br>
-2.3 Introduction to C# code <br>
-2.4 Writing Code for the Hello World Application <br>
-2.5 Label Controls <br>
-2.6 Making Sense of IntelliSense <br>
-2.7 PictureBox Controls <br>
-2.8 Comments, Blank Lines, and Indentation <br>
-2.9 Writing the Code to Close an Application’s Form <br>
-2.10 Dealing with Syntax Errors <br>

<h3?> what is C#? </h3>

C# (pronounce "C-sharp") is modern , general-purpose programming language developed application.



## <h4> Objects </h4>
An object is a program component that contains data and performs operations, Programs use objects to perform specific tasks.
Most programming languages use object-oriented programming in which a program component is called an “object”
Program objects have properties (or fields) and methods
Properties – data stored in an object
Methods – the operations an object can perform

## An object can have:
* Properties – data or characteristics of an object.
* Methods – operations that an object can perform.

## Example
A Button can have properties such as:

Name
Text
Size
Font

 <hr>

<h3>Controls</h3>

Controls are objects that are visible in a program’s Graphical User Interface (GUI).

Common controls include:

* Label
* Button
* TextBox
* PictureBox

Controls make a Windows Forms application interactive.

There are also invisible objects, such as:

* Timer
* OpenFileDialog

A class is code that describes a particular type of object.

 <hr>

<h3>.NET Framework </h3>

.NET is a collection of classes and other code that can be used to create applications for Windows.

C# is a programming language supported by .NET.

Controls used in Windows Forms are defined by specialized classes provided by .NET.

Developers can also create their own classes for special tasks.

 <hr>

<h3> Visual Studio</h3>

Visual Studio is a professional Integrated Development Environment (IDE).

It provides tools for designing, writing, running, and debugging applications.

Important parts of Visual Studio include:

* Designer Window
* Solution Explorer
* Properties Window
* Toolbox
* Code Editor
* Menu Bar
* Standard Toolbar

 <hr>

<h3> Toolbox </h3>

The Toolbox contains controls that can be added to a Windows Form.

A control can be added by:

1. Dragging it onto the form.
2. Double-clicking it.

 <hr>

<h3> Project and Solution </h3>

A Project contains the files needed to create an application.

A Solution is a container that can contain one or more projects.

Simple difference:

* Solution → contains projects
* Project → contains application files

 <hr>

<h3> Windows Forms </h3>

A Form is the main window of a Windows Forms application.

A form can contain controls such as:

Form
 ├── Label
 ├── TextBox
 ├── Button
 └── PictureBox


 <hr>


<h3> Properties Window </h3>

The Properties Window is used to change the appearance and behavior of objects.

Examples:

Text = My Program
Size = 300, 300
Name = messageButton


 <hr>

<h3> C# Code </h3>

C# programs are organized mainly into:

* Namespace – groups related classes.
* Class – defines a type of object.
* Method – contains statements that perform an operation.

Example:

namespace HelloWorld
{ <br>
    public class Student <br>
    { <br>
        public void DisplayMessage() <br>
        { <br>
            ///////////////// <br>
        } <br>
    } <br>
} <br>


 <hr>


<h3> Event-Driven Programming </h3>

Windows Forms applications are event-driven.

The program waits for an event and then responds to it.

Example:

User clicks Button
       ↓
Click Event
       ↓
Event Handler
       ↓
Action is performed

Example:

private void messageButton_Click(object sender, EventArgs e) <br>
 
{ <br>
    MessageBox.Show("Hello World"); <br>
} <br>


 <hr>


<h3> Label </h3>

A Label displays text on a form.

Example:

answerLabel.Text = "Hello World";

The = symbol is the assignment operator.


 <hr>


<h3> MessageBox </h3>

A MessageBox displays a message to the user.

messageBox.show("hello world").


 <hr>


<h3> IntelliSense </h3>

IntelliSense is a Visual Studio feature that provides code suggestions while typing.

It helps programmers:

* Write code faster.
* Find methods and properties.
* Reduce typing errors.


 <hr>


<h3> PictureBox </h3>

A PictureBox displays images on a Windows Form.

Example:

pictureBox1.Visible = true;
pictureBox2.Visible = false;


 <hr>


<h3> Comments </h3>

Comments explain code and are ignored by the compiler.

Single-line comment

// Close the form 

Multi-line comment

/*
 This is a comment
*/


<h4> Closing a Form </h4>

To close the current form:

this.Close();

To close the application:

Application.Exit();

 <hr>


<h3> Syntax Errors </h3>

A syntax error occurs when C# code does not follow the correct language rules.

Incorrect:

MessageBox.sho("Hello");

Correct:

MessageBox.Show("Hello");

Visual Studio helps identify syntax errors while writing code.
