# Chapter 3 — Making Decisions

**Textbook:** Starting Out with Visual C# (6th Edition) by Tony Gaddis
**Scope:** Slides 1 to 21

---

## Table of Contents

1. [Decision Structures & the `if` Statement](#1-decision-structures--the-if-statement)
2. [The `if-else` Statement](#2-the-if-else-statement)
3. [Nested Decision Structures](#3-nested-decision-structures)
4. [The `if-else-if` Statement](#4-the-if-else-if-statement)
5. [Logical Operators](#5-logical-operators)
6. [`bool` Variables and Flags](#6-bool-variables-and-flags)
7. [Comparing Strings](#7-comparing-strings)
8. [Preventing Data Conversion Exceptions with TryParse](#8-preventing-data-conversion-exceptions-with-tryparse)
9. [Input Validation](#9-input-validation)

---

## 1. Decision Structures & the `if` Statement

- **Control structure:** a logical design that controls the order in which statements execute.
- **Sequence structure:** statements execute in the order they appear.
- **Decision structure (selection structure):** statements execute **only under certain circumstances**, that is, a specific action is performed only if a certain condition exists.

### Single-alternative decision

It provides only one alternative path of execution. In C#, it is written with `if`:

if (expression)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;statement;  
&nbsp;&nbsp;&nbsp;&nbsp;statement;  
}  

The `expression` is a **Boolean expression** that evaluates to either `true` or `false`.

### Relational Operators

A relational operator determines whether a specific relationship exists between two values.

| Operator | Meaning | Expression | Question |
|:---:|---|---|---|
| `>` | Greater than | `x > y` | Is x greater than y? |
| `<` | Less than | `x < y` | Is x less than y? |
| `>=` | Greater than or equal to | `x >= y` | Is x greater than or equal to y? |
| `<=` | Less than or equal to | `x <= y` | Is x less than or equal to y? |
| `==` | Equal to | `x == y` | Is x equal to y? |
| `!=` | Not equal to | `x != y` | Is x not equal to y? |

### Example

if (sales > 50000)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;bonus = 500;  
}  

> If `sales` is greater than 50,000, `bonus` is set to 500.

---

## 2. The `if-else` Statement

Executes one block of statements if the Boolean expression is `true`, or another block if it is `false`. It has two parts: an **if clause** and an **else clause**.

if (expression)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;statements;   // when true  
}  
else  
{  
&nbsp;&nbsp;&nbsp;&nbsp;statements;   // when false  
}  

---

## 3. Nested Decision Structures

**Nested** means "one inside another." Use it to test **more than one condition**.

if (expression)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;if (expression)  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;statements;  
&nbsp;&nbsp;&nbsp;&nbsp;}  
&nbsp;&nbsp;&nbsp;&nbsp;else  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;statements;  
&nbsp;&nbsp;&nbsp;&nbsp;}  
}  
else  
{  
&nbsp;&nbsp;&nbsp;&nbsp;statements;  
}  

### Example: Qualifying for a loan

1. Is `salary >= 40000`?
   - **False** → display *"Minimum salary requirement not met"*
   - **True** → is `yearsOnJob >= 2`?
     - **False** → display *"Minimum years at current job not met"*
     - **True** → display *"You qualify for the loan"*

---

## 4. The `if-else-if` Statement

Evaluates **multiple conditions** in sequence to reach a final decision.

if (expression)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;statements;  
}  
else if (expression)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;statements;  
}  
else if (expression)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;statements;  
}  
else  
{  
&nbsp;&nbsp;&nbsp;&nbsp;statements;  
}  

---

## 5. Logical Operators

Logical operators connect multiple Boolean expressions to create a **compound expression**.

| Operator | Name | Description |
|:---:|:---:|---|
| `&&` | AND | **Both** subexpressions must be true for the compound expression to be true |
| `\|\|` | OR | **One or both** subexpressions must be true |
| `!` | NOT | Negates (reverses) the value to its opposite |

| Expression | Meaning |
|---|---|
| `x > y && a < b` | Is x greater than y **AND** is a less than b? |
| `x == y \|\| x == z` | Is x equal to y **OR** is x equal to z? |
| `!(x > y)` | Is the expression `x > y` **NOT** true? |

### Examples

// AND (&&)  
if (temperature < 20 && minutes > 12)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show("The temperature is in the danger zone.");  
}  
&nbsp;  
// OR (\|\|)  
if (temperature < 20 \|\| temperature > 100)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show("The temperature is in the danger zone.");  
}  
&nbsp;  
// NOT (!)  
if (!(temperature > 100))  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show("The temperature is below the maximum.");  
}  

---

## 6. `bool` Variables and Flags

- A `bool` variable can store only **`true`** or **`false`**.
- A **flag** is a variable that signals when some condition exists in the program:
  - `false` → the condition does **not** exist
  - `true` → the condition **exists**

bool isValid = false;  
&nbsp;  
// ... after some checking  
isValid = true;  
&nbsp;  
if (isValid)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;// continue  
}  

---

## 7. Comparing Strings

There are three common ways to compare strings:

// 1) Use ==  
if (name1 == name2)  
{  
}  
&nbsp;  
// 2) Compare with a string literal  
if (name1 != "bob")  
{  
}  
&nbsp;  
// 3) Use the String.Compare method  
if (String.Compare(name1, name2) == 0)  
{  
}  

> `String.Compare(a, b) == 0` means the two strings are equal.

---

## 8. Preventing Data Conversion Exceptions with TryParse

Exceptions should be prevented when possible. The **TryParse** methods prevent exceptions caused by users entering invalid data.

| Method | Type |
|---|---|
| `int.TryParse` | Integer |
| `double.TryParse` | Double |
| `decimal.TryParse` | Decimal |

**Syntax:**

dataType.TryParse(string input, out targetVariable)  

- The `out` keyword is **required**; it specifies that `targetVariable` is an **output variable**.
- It returns `true` if the conversion succeeds and `false` otherwise.

---

## 9. Input Validation

**Input validation** is the process of inspecting data entered into a program to make sure it is valid before it is used.

> ⚠️ `TryParse` checks that the user entered a **number**, but not that the number is **reasonable**.
> For example, if the user types `999`, `TryParse` accepts it as valid, but nobody can work 999 hours in a week. The data's integrity must be verified separately.

### Example 1: Payroll (hours worked)

int hours;  
&nbsp;  
if (int.TryParse(textBox1.Text, out hours))  
{  
&nbsp;&nbsp;&nbsp;&nbsp;// TryParse succeeded: it's a number!  
&nbsp;&nbsp;&nbsp;&nbsp;if (hours > 0 && hours <= 168)  
&nbsp;&nbsp;&nbsp;&nbsp;{  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;// hours are valid  
&nbsp;&nbsp;&nbsp;&nbsp;}  
}  

> A week has 168 hours (7 × 24).

### Example 2: Test scores

if (testScore >= 0 && testScore <= 100)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;// score is valid  
}  

---

## Quick Summary

| Topic | Key idea |
|---|---|
| `if` | Run code when a condition is `true` |
| `if-else` | Two alternatives: `true` or `false` |
| Nested | A decision inside another decision |
| `if-else-if` | Several conditions tested in order |
| `&&`, `\|\|`, `!` | Combine or reverse Boolean expressions |
| `bool` flag | A variable signaling that a condition exists |
| String comparison | `==`, `!=`, `String.Compare` |
| `TryParse` | Avoid conversion exceptions |
| Validation | Check that data is **reasonable**, not just numeric |

---

*Source: Gaddis, Starting Out with Visual C#, 6e, Pearson Education. Chapter slides 1–21.*