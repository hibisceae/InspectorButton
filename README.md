# InspectorButton

**InspectorButton** is a Unity library that adds clickable buttons to the Inspector for any method marked with a simple attribute. It allows developers to execute methods—optionally with parameters—without writing custom editors, making it ideal for debugging, testing, and tool workflows.

## Features

* Adds Inspector buttons via attribute
* Supports **methods with parameters**
* Works in Edit Mode and Play Mode
* No custom editor coding required
* Helpful for automation, debugging, and utility calls

## Installation

1. Open Unity **Package Manager**
2. Select **Add package from Git URL…**
3. Enter the repository URL:

```
https://github.com/hibisceae/InspectorButton.git
```

The package will be installed automatically and become available in your project.

## Getting Started

1. Import the namespace:

```csharp
using InspectorButton;
```

2. Add the attribute to any method.

### Parameterless Example

```csharp
[InspectorButton("Sample")]
private void SampleMethod()
{
    Debug.Log("Hi from sample method!");
}
```

### Parameter Example

```csharp
[InspectorButton("Sample With Parameter", 10)]
private void SampleWithParameter(Int32 number)
{
    Debug.Log($"Hi from sample method, parameter {number}");
}
```

* The first argument is the button label.
* From the second argument onward, all values are passed as parameters when the method is invoked.

3. Select the component in the Inspector.
   Buttons will appear automatically, and clicking them will immediately invoke the methods.

## Example

```csharp
using UnityEngine;
using InspectorButton;
using System;

public class ButtonSample : MonoBehaviour 
{
    [InspectorButton("Sample")]
    private void SampleMethod()
    {
        Debug.Log("Hi from sample method!");
    }

    [InspectorButton("Sample With Parameter", 10)]
    private void SampleWithParameter(Int32 number)
    {
        Debug.Log($"Hi from sample method, parameter {number}");
    }
}
```

When the component is selected, the following buttons will appear:

* **Sample**
* **Sample With Parameter**

## Notes

- Buttons will only invoke methods during Play Mode.
- A single method can also have multiple attributes.

## License

This project is licensed under the MIT License.
