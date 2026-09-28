# introduction to C#

## Topics
-1.1 Objects
-1.2 The Program Development Process
-1.8 Getting Started with Visual Studio
-2.1 Getting Started with Forms and Controls
-2.2 Creating the G U I for Your First Visual C# Application
-2.3 Introduction to C# code
-2.4 Writing Code for the Hello World Application
-2.5 Label Controls
-2.6 Making Sense of IntelliSense
-2.7 PictureBox Controls
-2.8 Comments, Blank Lines, and Indentation
-2.9 Writing the Code to Close an Application’s Form
-2.10 Dealing with Syntax Errors

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



<h3>.NET Framework </h3>

.NET is a collection of classes and other code that can be used to create applications for Windows.

C# is a programming language supported by .NET.

Controls used in Windows Forms are defined by specialized classes provided by .NET.

Developers can also create their own classes for special tasks.



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



<h4> Toolbox </h4>

The Toolbox contains controls that can be added to a Windows Form.

A control can be added by:

1. Dragging it onto the form.
2. Double-clicking it.



<h4> Project and Solution </h4>

A Project contains the files needed to create an application.

A Solution is a container that can contain one or more projects.

Simple difference:

* Solution → contains projects
* Project → contains application files



<h4> Windows Forms </h4>

A Form is the main window of a Windows Forms application.

A form can contain controls such as:

Form
 ├── Label
 ├── TextBox
 ├── Button
 └── PictureBox




<h4> Properties Window </h4>

The Properties Window is used to change the appearance and behavior of objects.

Examples:

Text = My Program
Size = 300, 300
Name = messageButton




<h4> C# Code </h4>

C# programs are organized mainly into:

* Namespace – groups related classes.
* Class – defines a type of object.
* Method – contains statements that perform an operation.

Example:

namespace HelloWorld
{
    public class Student
    {
        public void DisplayMessage()
        {
            /////////////////
        }
    }
}



<h4> Event-Driven Programming </h4>

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

private void messageButton_Click(object sender, EventArgs e)

{
    MessageBox.Show("Hello World");
}



<h4> Label </h4>

A Label displays text on a form.

Example:

answerLabel.Text = "Hello World";

The = symbol is the assignment operator.




<h4> MessageBox </h4>

A MessageBox displays a message to the user.

messageBox.show("hello world").




<h4> IntelliSense </h4>

IntelliSense is a Visual Studio feature that provides code suggestions while typing.

It helps programmers:

* Write code faster.
* Find methods and properties.
* Reduce typing errors.




<h4> PictureBox </h4>

A PictureBox displays images on a Windows Form.

Example:

pictureBox1.Visible = true;
pictureBox2.Visible = false;




<h4> Comments </h4>

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




<h4> Syntax Errors </h4>

A syntax error occurs when C# code does not follow the correct language rules.

Incorrect:

MessageBox.sho("Hello");

Correct:

MessageBox.Show("Hello");

Visual Studio helps identify syntax errors while writing code.
