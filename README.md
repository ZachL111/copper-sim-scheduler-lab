# copper-sim-scheduler-lab

`copper-sim-scheduler-lab` is a focused C# codebase around create a C# reference implementation for scheduler workflows, centered on simulation kernel, seeded input scenarios, and deterministic summary checks. It is meant to be easy to inspect, run, and extend without a hosted service.

## Copper Sim Scheduler Lab Walkthrough

I would read the project from the outside in: command, fixture, model, then roadmap. That keeps the simulations idea grounded in files that can be checked locally.

## Reason For The Project

This is not a wrapper around a service. It is a self-contained project that shows how the model behaves when demand, capacity, latency, risk, and weight move in different directions.

## Capabilities

- Models input state with deterministic scoring and explicit review decisions.
- Uses fixture data to keep policy checks changes visible in code review.
- Includes extended examples for fixture data, including `recovery` and `degraded`.
- Documents local reports tradeoffs in `docs/operations.md`.
- Runs locally with a single verification command and no external credentials.

## How It Is Put Together

The design is intentionally direct: parse or construct a signal, score it, classify it, and verify the expected branch. This makes the repository useful for studying simulations behavior without needing a service or database unless the language project itself is SQL. The C# code keeps the core model in a small static API and runs checks through the executable path.

## Where Things Live

- `src`: primary implementation
- `tests`: verification harness
- `fixtures`: compact golden scenarios
- `examples`: expanded scenario set
- `metadata`: project constants and verification metadata
- `docs`: operations and extension notes
- `scripts`: local verification and audit commands

## Getting It Running

Clone the repository, enter the directory, and run the verifier. No database server, cloud account, or token is required.

## Command Examples

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

This runs the language-level build or test path against the compact fixture set.

## Check The Work

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/audit.ps1
```

The audit command checks repository structure and README constraints before it delegates to the verifier.

## Data Notes

`baseline` is the first example I would inspect because it lands on the `review` path with a score of 139. The broader file also keeps `degraded` at 14 and `recovery` at 228, which gives the model a useful low-to-high spread.

## Tradeoffs

This code is local-first. It makes no claim about deployed usage and avoids credentials, hosted state, and environment-specific setup.

## Possible Extensions

- Add a short report command that prints the score breakdown for a single scenario.
- Add malformed input fixtures so the failure path is as visible as the happy path.
- Split the scoring constants into a typed configuration object and validate it before use.
- Add one more simulations fixture that focuses on a malformed or borderline input.
