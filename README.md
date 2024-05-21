# Kayki.StringUtils

[![NuGet](https://img.shields.io/nuget/v/Kayki.StringUtils.svg)](https://www.nuget.org/packages/Kayki.StringUtils/)
[![GitHub](https://img.shields.io/github/license/kaykiletieri/string-utils-package)](https://github.com/kaykiletieri/string-utils-package/blob/main/LICENSE)

Kayki.StringUtils is a .NET package offering a comprehensive set of utilities for string manipulation and validation tasks.

## Features

- **String Manipulation:** Simplify tasks such as space removal, character counting...
- **Validation:** Validate various formats including dates, CPF, CNPJ, and emails...
- **Cultural Support:** Adapt date formats and validations according to specific cultures.

## Installation

You can install the package via [NuGet](https://www.nuget.org/packages/Kayki.StringUtils/):

```bash
dotnet add package Kayki.StringUtils
```

## Usage
Here's a quick example of how to use Kayki.StringUtils in your .NET project:

```cs
using Kayki.StringUtils;

class Program
{
    static void Main()
    {
        string input = "Hello World";
        string reversed = StringHelper.Reverse(input);
        Console.WriteLine(reversed); // Output: dlroW olleH
    }
}
```
For detailed usage instructions and API documentation, please refer to the Wiki.

## Contributing
Contributions are welcome! Please feel free to open issues or submit pull requests to help improve this package.
