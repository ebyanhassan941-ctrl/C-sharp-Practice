# Chapter 2: Processing Data

**Course:** C# Practice  
**Book:** Starting Out with Visual C# (6th Edition) by Tony Gaddis  
**Student:** hassan941-ctrl

---

## Topics

1. Reading Input with TextBox
2. Variables
3. Numeric Data Types
4. Calculations
5. Input and Output of Numbers
6. Formatting Numbers
7. Exception Handling
8. Named Constants
9. Fields
10. Math Class
11. GUI Details
12. Debugging

<br>

---

## 1. Reading Input with TextBox

A **TextBox** is a control that lets the user type text into the form.

- The default name is `textBox1`, `textBox2`, and so on.
- The text the user types is stored in the `Text` property.
- The `Text` property only accepts **strings**.

```csharp
textBox1.Text = "Hello";
```

To clear a TextBox, use any one of these:

```csharp
textBox1.Text = "";
textBox1.Text = string.Empty;
textBox1.Clear();
```

<br>

---

## 2. Variables

A **variable** is a place in memory where we store data. We must declare a variable before we use it.

```csharp
DataType VariableName;
```

**Naming rules:**

- Must start with a letter or an underscore (`_`)
- No spaces
- Cannot be a C# keyword
- Use a meaningful name

**String variable:** stores text. The value goes inside double quotes.

```csharp
string productDescription = "Jamhuuriya University";
MessageBox.Show(productDescription);
```

**Concatenation:** joining strings together with `+`.

```csharp
string fullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;
```

**Local variable and scope:** a variable declared inside a method can only be used inside that method.

```csharp
private void firstButton_Click(object sender, EventArgs e)
{
    string myName = nameTextBox.Text;
}

private void secondButton_Click(object sender, EventArgs e)
{
    outputLabel.Text = myName;   // ERROR: myName does not exist here
}
```

**Important rules:**

- Two variables in the same scope cannot have the same name.
- A variable must get a value before we use it.
- We can declare many variables in one line:

```csharp
string lastName, firstName, middleName;
```

<br>

---

## 3. Numeric Data Types

| Type | What it stores | Example |
|------|----------------|---------|
| `int` | Whole numbers | `int hoursWorked = 40;` |
| `double` | Numbers with decimals | `double temperature = 87.6;` |
| `decimal` | Decimals with high precision (used for money) | `decimal payRate = 28.75m;` |

A `decimal` value must end with `m`.

**What can each type accept?**

| Variable | Accepts | Does not accept |
|----------|---------|-----------------|
| `int` | int | double, decimal |
| `double` | double, int | decimal |
| `decimal` | decimal, int | double |

**Casting** changes one type into another:

```csharp
decimal moneyNumber = 4500m;
int wholeNumber = (int)moneyNumber;
```

**The `var` keyword:** the compiler chooses the type from the value.

```csharp
var interestRate = 12.0;      // double
var stockCode = "D465U";      // string
```

<br>

---

## 4. Calculations

| Operator | Name |
|:--------:|------|
| `+` | Addition |
| `-` | Subtraction |
| `*` | Multiplication |
| `/` | Division |
| `%` | Modulus (remainder) |

```csharp
int x = 5, y = 4;
MessageBox.Show((x + y).ToString());
```

**Mixed types:**

- int + double = double
- int + decimal = decimal
- double + decimal = not allowed

**Integer division:** int divided by int gives an int.

```csharp
int x = 7, y = 3;
MessageBox.Show((x / y).ToString());             // 2

MessageBox.Show(((double)x / y).ToString());     // 2.33333
```

<br>

---

## 5. Input and Output of Numbers

A TextBox always gives a **string**. To use it as a number, we use **Parse**.

```csharp
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
decimal payRate = decimal.Parse(payRateTextBox.Text);
```

To show a number in a Label or TextBox, we convert it to a string with **ToString()**.

```csharp
decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();
```

<br>

---

## 6. Formatting Numbers

| Format | Meaning | Example | Result |
|:------:|---------|---------|--------|
| `n` | Number | `12.3.ToString("n3")` | 12.300 |
| `f` | Fixed-point | `123456.0.ToString("f2")` | 123456.00 |
| `e` | Exponential | `123456.0.ToString("e3")` | 1.235e+005 |
| `c` | Currency | `1234567.8.ToString("c")` | $1,234,567.80 |
| `p` | Percent | `.234.ToString("p")` | 23.40% |

<br>

---

## 7. Exception Handling

An **exception** is an error that happens while the program is running (for example, dividing by zero or wrong input from the user). If we do not handle it, the program crashes.

We use **try-catch** to handle it:

- The `try` block has the code that may cause an error.
- The `catch` block has the code that runs if there is an error.

```csharp
try
{
    double miles = double.Parse(milesTextBox.Text);
    double gallons = double.Parse(gallonsTextBox.Text);
    double mpg = miles / gallons;
    mpgLabel.Text = mpg.ToString();
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}
```

**Throwing and catching**

- **Throwing** = the error happens.
- **Catching** = the program handles the error.

Example: at an ATM, a wrong PIN throws an error, and the ATM shows "Invalid PIN, please try again" (catching).

**Showing the default error message:**

```csharp
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

<br>

---

## 8. Named Constants

A **constant** is a value that cannot change while the program runs. We use the `const` keyword.

```csharp
const double INTEREST_RATE = 0.129;
```

<br>
