[![Build status](https://ci.appveyor.com/api/projects/status/github/bytedev/ByteDev.ArgValidation?branch=master&svg=true)](https://ci.appveyor.com/project/bytedev/ByteDev-ArgValidation/branch/master)
[![NuGet Package](https://img.shields.io/nuget/v/ByteDev.ArgValidation.svg)](https://www.nuget.org/packages/ByteDev.ArgValidation)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/490a3d7051e04bcd91f561c0c3de4f72)](https://www.codacy.com/manual/ByteDev/ByteDev.ArgValidation?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=ByteDev/ByteDev.ArgValidation&amp;utm_campaign=Badge_Grade)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/ByteDev/ByteDev.ArgValidation/blob/master/LICENSE)

# ByteDev.ArgValidation

Set of helper methods to help validate arguments.

## Installation

ByteDev.ArgValidation has been written as a .NET Standard 2.0 library, so you can consume it from a .NET Core or .NET Framework 4.6.1 (or greater) application.

ByteDev.ArgValidation is hosted as a package on nuget.org.  To install from the Package Manager Console in Visual Studio run:

`Install-Package ByteDev.ArgValidation`

Further details can be found on the [nuget page](https://www.nuget.org/packages/ByteDev.ArgValidation/).

## Release Notes

Releases follow semantic versioning.

Full details of the release notes can be viewed on [GitHub](https://github.com/ByteDev/ByteDev.ArgValidation/blob/master/docs/RELEASE-NOTES.md).

## Usage

All argument validation can be performed through the `ArgValidator` class.  This class has a number of static methods:
- DependentNotNull
- GreaterThan
- GreaterThanOrEqual
- In
- LessThan
- LessThanOrEqual
- NotDefault
- NotEmpty
- NotEquals
- NotIn
- NotNull
- NotNullOrEmpty

Example:

```csharp
public Customer GetCustomer(int id)
{
	ArgValidator.GreaterThan(id, 0, nameof(id));

	// ...
}
```