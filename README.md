# copper-sim-scheduler-lab

`copper-sim-scheduler-lab` keeps a focused C# implementation around simulations. The project goal is to create a C# reference implementation for scheduler workflows, centered on simulation kernel, seeded input scenarios, and deterministic summary checks.

## Problem It Tries To Make Smaller

The project exists to keep a narrow engineering decision visible and testable. For this repo, that decision is how input pressure and review cost should influence a review result.

## Copper Sim Scheduler Lab Review Notes

Start with `input pressure` and `state drift`. Those cases create the widest score spread in this repo, so they are the best quick check when the model changes.

## Working Pieces

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/copper-sim-scheduler-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `input pressure` and `state drift`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Design Notes

The core code exposes a scoring path and the added review layer uses `signal`, `slack`, `drag`, and `confidence`. The domain terms are `input pressure`, `state drift`, `review cost`, and `decision risk`.

The C# code keeps the review rule close to the tests.

## Example Run

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Tests

That command is also the regression path. It verifies the domain cases and catches mismatches between the CSV, metadata, and code.

## Known Limits

No external service is required. A deeper version would add more negative cases and a clearer boundary around invalid input.
