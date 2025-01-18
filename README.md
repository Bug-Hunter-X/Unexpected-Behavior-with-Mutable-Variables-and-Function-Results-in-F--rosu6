# F# Mutable Variable Pitfall

This example demonstrates a potential issue when working with mutable variables and function results in F#. While `mutable` allows variable reassignment, the result of a function call isn't automatically updated when input variables change.  This can lead to subtle bugs if not handled carefully.

The `bug.fs` file contains the buggy code, showcasing the unexpected behavior. `bugSolution.fs` provides a corrected version that avoids the issue by recalculating the result whenever necessary. 