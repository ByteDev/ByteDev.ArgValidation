[![Build status](https://ci.appveyor.com/api/projects/status/github/bytedev/ByteDev.ArgValidation?branch=master&svg=true)](https://ci.appveyor.com/project/bytedev/ByteDev-ArgValidation/branch/master)
[![NuGet Package](https://img.shields.io/nuget/v/ByteDev.ArgValidation.svg)](https://www.nuget.org/packages/ByteDev.ArgValidation)

# ByteDev.ArgValidation

Set of helper methods to help validate arguments.

## Installation

ByteDev.ArgValidation has been written as a .NET Standard 2.0 library, so you can consume it from a .NET Core or .NET Framework 4.6.1 (or greater) application.

ByteDev.ArgValidation is hosted as a package on nuget.org.  To install from the Package Manager Console in Visual Studio run:

`Install-Package ByteDev.ArgValidation`

Further details can be found on the [nuget page](https://www.nuget.org/packages/ByteDev.ArgValidation/).

## Release Notes

Releases follow semantic versioning.

Full details of the release notes can be viewed on [GitHub](https://github.com/ByteDev/ByteDev.ArgValidation/blob/master/RELEASE-NOTES.md).

## Code

The repo can be cloned from git bash:

`git clone https://github.com/ByteDev/ByteDev.ArgValidation`

## Usage

All argument validation can be performed through the `ArgValidator` class.  This class has a number of static methods:
- DependentNotNull
- NotNull
- NotDefault
- NotEmpty
- NotNullOrEmpty
- NotEquals
- GreaterThan
- GreaterThanOrEqual
- LessThan
- LessThanOrEqual

Example:

```
public Customer GetCustomer(int id)
{
	ArgValidator.GreaterThan(id, 0, nameof(id));

	// ...
}
```