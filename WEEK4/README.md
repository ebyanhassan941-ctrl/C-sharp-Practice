# Chapter 3 — Making Decisions (Part 2)

**Textbook:** Starting Out with Visual C# (6th Edition) by Tony Gaddis
**Scope:** Slides 22 to 33

---

## Table of Contents

1. [Radio Buttons and Check Boxes](#1-radio-buttons-and-check-boxes)
2. [RadioButton Control](#2-radiobutton-control)
3. [CheckBox Control](#3-checkbox-control)
4. [The CheckedChanged Event](#4-the-checkedchanged-event)
5. [The `switch` Statement](#5-the-switch-statement)
6. [Introduction to List Boxes](#6-introduction-to-list-boxes)
7. [Adding Items to a ListBox](#7-adding-items-to-a-listbox)
8. [SelectedItem and SelectedIndex](#8-selecteditem-and-selectedindex)
9. [Text vs SelectedItem](#9-text-vs-selecteditem)
10. [Removing Items from a ListBox](#10-removing-items-from-a-listbox)

---

## 1. Radio Buttons and Check Boxes

| Control | What it does |
|---|---|
| **Radio button** | Lets the user select **one choice** from several. Clicking one automatically deselects the others (**mutually exclusive selection**). |
| **Check box** | Lets the user select **multiple options** at the same time. |

**Examples:**
- Radio buttons: *Select your favorite sport* → Football, Basketball, Baseball (only one can be selected).
- Check boxes: *Select your pizza toppings* → Pepperoni, Cheese, Anchovies (any combination).

---

## 2. RadioButton Control

.NET provides the **RadioButton** control to create a group of radio buttons.

**Common properties:**

| Property | Description |
|---|---|
| `Text` | The text displayed next to the radio button |
| `Checked` | Boolean: `true` if selected, `false` if deselected |

In code, use a decision structure to find out whether a RadioButton is selected:

if (choiceRadioButton.Checked)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;// selected  
}  
else  
{  
&nbsp;&nbsp;&nbsp;&nbsp;// not selected  
}  

You do not need the `==` operator, but this is equivalent:

if (choiceRadioButton.Checked == true)  
{  
}  

---

## 3. CheckBox Control

The **CheckBox** control gives the user an option such as true/false or yes/no. It has the same common properties: `Text` and `Checked`.

if (option1CheckBox.Checked)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;// checked  
}  
else  
{  
&nbsp;&nbsp;&nbsp;&nbsp;// not checked  
}  

---

## 4. The CheckedChanged Event

Whenever the `Checked` property of a radio button or check box changes, a **CheckedChanged** event is raised. You can write an event handler to respond to it.

**Tip:** Double-click the control in the Designer to create an empty handler:

private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)  
{  
}  

---

## 5. The `switch` Statement

The `switch` statement lets the value of a variable or expression determine which path the program takes. It is a **multiple-alternative decision structure**, and it can replace an `if-else-if` chain that tests the same variable for several values.

switch (testExpression)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;case value_1:  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;statement;  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;break;  
&nbsp;&nbsp;&nbsp;&nbsp;case value_2:  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;statement;  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;break;  
&nbsp;&nbsp;&nbsp;&nbsp;default:  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;statement;  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;break;  
}  

**General rules:**
- `testExpression` is a variable or expression that gives an `int`, `string`, or `bool` value.
- Each `case` is a subsection with one or more statements, followed by a `break`.
- `default` is **optional**. It runs when `testExpression` matches none of the cases.

---

## 6. Introduction to List Boxes

A **ListBox** control displays a list of items and lets the user select one.

| Property | Description |
|---|---|
| `Text` | Text of the currently selected item |
| `Items` | The items in the ListBox |
| `Items.Count` | Total number of items |
| `SelectedItem` | The currently selected item (set when the user selects one) |
| `SelectedIndex` | Zero-based index of the selected item |

Get the selected item as a string:

selectedFruit = fruitListBox.SelectedItem.ToString();  

---

## 7. Adding Items to a ListBox

Use the `Items.Add` method:

ListBox.Items.Add(NewItem);  

`ListBox` is the control's name and `NewItem` is the value to add.

daysListBox.Items.Add("Monday");  
daysListBox.Items.Add("Tuesday");  
daysListBox.Items.Add("Wednesday");  

---

## 8. SelectedItem and SelectedIndex

- An **exception** occurs if you read `SelectedItem` when **no item is selected**.
- Items are indexed from **0**: the first item is index 0, and the nth item is index n – 1.
- `SelectedIndex` is **-1** when nothing is selected.

Check before reading `SelectedItem`:

if (fruitListBox.SelectedIndex != -1)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;selectedFruit = fruitListBox.SelectedItem.ToString();  
}  

---

## 9. Text vs SelectedItem

| Feature | `Text` | `SelectedItem` |
|---|---|---|
| Type | `string` | `object` |
| Use case | Quick access to the selected text | Full access to the selected item |
| Flexibility | Less flexible | More flexible (can be cast to another type) |
| Nothing selected | Might return `""` | Might be `null` |
| Best for | Simple, text-only lists | Complex or data-bound lists |

**Behind the scenes:** `SelectedItem` can be a real object (like a Student or Book), while `Text` simply gives the name shown in the ListBox.

---

## 10. Removing Items from a ListBox

| Method | Purpose | Example |
|---|---|---|
| `Items.Remove(Item)` | Removes a **specific item** | `daysListBox.Items.Remove("Tuesday");` |
| `Items.RemoveAt(Index)` | Removes the item at a **specific index** | `daysListBox.Items.RemoveAt(2);` |
| `Items.Clear()` | Erases **all** items | `daysListBox.Items.Clear();` |

>  For `RemoveAt`, the index must be valid: not less than 0, and not greater than or equal to the number of items. Otherwise an exception is thrown.

---

## Quick Summary

| Topic | Key idea |
|---|---|
| RadioButton | Pick one; check with `.Checked` |
| CheckBox | Pick many; check with `.Checked` |
| CheckedChanged | Event raised when `Checked` changes |
| `switch` | Multiple-way decision on one value |
| ListBox | List of items the user can select |
| `Items.Add` | Add an item |
| `SelectedIndex != -1` | Make sure something is selected |
| `Remove`, `RemoveAt`, `Clear` | Delete one item, an item by index, or all |

---

*Source: Gaddis, Starting Out with Visual C#, 6e, Pearson Education. Chapter slides 22–33.*