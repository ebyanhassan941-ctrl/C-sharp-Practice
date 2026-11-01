# Chapter 4 — Loops

### while, ++ / --, for, and do-while

**Textbook:** Starting Out with Visual C# (6th Edition) by Tony Gaddis
**Scope:** Slides 1 to 20

---

## Table of Contents

1. [The `while` Loop](#1-the-while-loop)
2. [Pretest Loop](#2-the-while-loop-is-a-pretest-loop)
3. [Infinite Loops](#3-infinite-loops)
4. [The `++` and `--` Operators](#4-the--and----operators)
5. [Postfix vs Prefix Mode](#5-postfix-vs-prefix-mode)
6. [The `for` Loop](#6-the-for-loop)
7. [Other Forms of the Update Expression](#7-other-forms-of-the-update-expression)
8. [The `do-while` Loop](#8-the-do-while-loop)
9. [Quick Summary](#-quick-summary)

---

## 1. The `while` Loop

A **while loop** repeats a statement or a set of statements **as long as a Boolean expression is true**.

> Simple logic: *While a Boolean expression is true, do some task.*

**A while loop has two parts:**
1. A **Boolean expression** that is tested for `true` or `false`.
2. A **statement or set of statements** that repeats as long as the expression is true.

**General format:**

while (BooleanExpression)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;statements  
}  

**Terminology:**

| Term | Meaning |
|---|---|
| **while clause** | The first line: `while (BooleanExpression)` |
| **Body of the loop** | The statements inside the curly braces |
| **Iteration** | Each single time the loop runs its body |
| **Counter variable** | A variable used to track how many times a loop runs |

When the loop executes, the Boolean expression is tested first. If it is `true`, the body runs, and then the expression is tested again.

---

## 2. The `while` Loop is a Pretest Loop

A while loop is a **pretest loop**: it tests its condition **before** performing an iteration. So you usually have to prepare things before the loop to make sure it runs at least once.

**Example: runs 5 times**

int count = 0;  
while (count < 5)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show("Hello");  
&nbsp;&nbsp;&nbsp;&nbsp;count = count + 1;  
}  

`count` starts at 0, which is less than 5, so the loop iterates **5 times**.

**Example: never runs**

int count = 5;  
while (count < 5)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show("Hello");  
&nbsp;&nbsp;&nbsp;&nbsp;count = count + 1;  
}  

The condition is **false from the start**, so the loop **does not iterate at all**.

---

## 3. Infinite Loops

An **infinite loop** repeats until the program is interrupted. A typical cause is forgetting to write code that makes the test condition `false`.

int count = 0;  
while (count < 5)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show("Hello");  
}  

 `count` is **never increased**, so `count < 5` is always `true` and the loop never stops.

**Fix:** add `count++;` inside the loop body.

---

## 4. The `++` and `--` Operators

- To **increment** a variable means to **increase** its value.
- To **decrement** a variable means to **decrease** its value.

C# provides `++` and `--` for this.

**Adding 1** (all three are equivalent):

count++;  
count += 1;  
count = count + 1;  

**Subtracting 1** (all three are equivalent):

count--;  
count -= 1;  
count = count - 1;  

---

## 5. Postfix vs Prefix Mode

| Mode | Position | Meaning | Example |
|---|---|---|---|
| **Postfix** | Operator **after** the variable | Use the **old** value, then change it | `count++` |
| **Prefix** | Operator **before** the variable | **Change** the value first, then use it | `++count` |

**Example:**

int x = 5;  
int y;  
&nbsp;  
y = x++;   // y gets 5, then x becomes 6  (postfix)  
&nbsp;  
x = 5;  
y = ++x;   // x becomes 6 first, then y gets 6  (prefix)  

---

## 6. The `for` Loop

The **for loop** is designed for situations where a **counter variable** controls how many times the loop iterates. It is also a **pretest loop**.

**You must specify three actions:**

| Action | Description |
|---|---|
| **Initialization** | A one-time expression that sets the starting value of the counter |
| **Test** | A Boolean expression; if `true`, the loop iterates |
| **Update** | Increases or decreases the counter |

**General format:**

for (InitializationExpression; TestExpression; UpdateExpression)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;statements  
}  

**Example: declare the counter in the loop**

for (int count = 0; count < 5; count++)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show("Hello");  
}  

**Example: declare the counter before the loop**

int count;  
for (count = 0; count < 5; count++)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show("Hello");  
}  

**How it runs:**
1. The initialization expression sets `count` to 0 (runs **once**).
2. `count < 5` is tested. If `true`, the body runs.
3. The update expression adds 1 to `count`.
4. The loop starts over at step 2.

---

## 7. Other Forms of the Update Expression

The counter is usually incremented by 1, but this is **not required**.

**Increment by 10:**

for (int count = 0; count <= 100; count += 10)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(count.ToString());  
}  

**Count backward:**

for (int count = 10; count >= 0; count--)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(count.ToString());  
}  

---

## 8. The `do-while` Loop

The **do-while loop** is a **posttest loop**: it performs an iteration **before** testing its Boolean expression. The statements always run **at least once**.

**General format:**

do  
{  
&nbsp;&nbsp;&nbsp;&nbsp;statements  
} while (BooleanExpression);  

Notice the **semicolon** after the `while (...)`.

### Will you see the message box?

**do-while: YES (once)**

int number = 1;  
do  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(number.ToString());  
} while (number < 0);  

The body runs first, then the condition `1 < 0` is false, so the loop stops after **1 iteration**.

**while: NO**

int number = 1;  
while (number < 0)  
{  
&nbsp;&nbsp;&nbsp;&nbsp;MessageBox.Show(number.ToString());  
}  

The condition `1 < 0` is false from the start, so the body **never runs**.

---

## Quick Summary

| Loop | Type | Runs at least once? | Best used when |
|---|---|---|---|
| `while` | Pretest | No | You don't know how many times in advance |
| `for` | Pretest | No | You know the number of iterations (counter) |
| `do-while` | Posttest | **Yes** | The body must run at least once |

| Operator | Effect |
|---|---|
| `x++` / `++x` | Add 1 |
| `x--` / `--x` | Subtract 1 |
| `x += n` | Add n |
| `x -= n` | Subtract n |

---

*Source: Gaddis, Starting Out with Visual C#, 6e, Pearson Education. Chapter 4 slides 1–20.*