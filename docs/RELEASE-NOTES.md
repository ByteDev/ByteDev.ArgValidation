# Release Notes

## 3.1.0 - 04 June 2021

Breaking changes:
- (None)

New features:
- Added `NotNullOrWhiteSpace`.
- Added `Between`.

Bug fixes / internal changes:
- Fixed bug in `In`, `NotIn`, `GreaterThan`, `GreaterThanOrEqual`, `LessThan`, `LessThanOrEqual` where param name being set with exception message.

## 3.0.0 - 03 June 2021

Breaking changes:
- Renamed type `ArgValidator` to `ArgMustBe`.
- Renamed method `DependencyNotNull` to `NotNullDependency`.

New features:
- (None)

Bug fixes / internal changes:
- (None)

## 2.0.0 - 25 January 2021

Breaking changes:
- Removed `DependentNullException`.
- Renamed method `DependentNotNull` to `DependencyNotNull`.
- Method `DependencyNotNull` now throws `DependencyNullException`.
- Method `NotDefault` now throws `ArgumentDefaultException`.
- Method `NotEmpty` now throws `ArgumentEmptyException`.
- Method `NotNullOrEmpty` now throws `ArgumentNullOrEmptyException`.

New features:
- (None)

Bug fixes / internal changes:
- Various fixes to handle nulls better.
- Now uses `ByteDev.Exceptions` package dependency.

## 1.0.1 - 20 January 2021

Breaking changes:
- (None)

New features:
- (None)

Bug fixes / internal changes:
- Package fixes for license, icon and project URL.

## 1.0.0 - 05 February 2020

Initial version.
