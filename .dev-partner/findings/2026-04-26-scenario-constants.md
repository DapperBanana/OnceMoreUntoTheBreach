---
title: Centralize scenario selection with constants
date: 2026-04-26
tags: [refactor, maintainability]
type: pattern
project: DapperBanana/OnceMoreUntoTheBreach
---

Using constants for scenario selection improves code readability and maintainability. Instead of using magic strings or numbers directly in the code, constants like `const int ScenarioOne = 1;` and `const int ScenarioTwo = 2;` are defined. This approach makes the code easier to understand and modify, as the meaning of each scenario is explicitly defined. If the scenario numbers ever need to change, you only need to update the constant definition, rather than searching and replacing throughout the codebase, reducing the risk of errors and improving overall code quality.
