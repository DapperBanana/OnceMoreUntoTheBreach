---
title: Scenario Logic in Functions
date: 2026-04-05
tags: [refactoring, modularity]
type: pattern
project: DapperBanana/OnceMoreUntoTheBreach
---

The move to put each scenario's logic into its own function is a good step towards maintainability. As the game grows, keeping scenarios isolated will prevent the main loop from becoming unwieldy. Each choice and outcome can be more easily managed.  Consider further isolating combat encounters and dialogue sequences within the scenarios themselves for even better separation of concerns.
