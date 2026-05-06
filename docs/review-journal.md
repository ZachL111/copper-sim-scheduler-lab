# Review Journal

The review surface for `copper-sim-scheduler-lab` is deliberately narrow: one fixture, one scoring rule, and one local check.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 149, lane `ship`
- `stress`: `state drift`, score 88, lane `hold`
- `edge`: `review cost`, score 199, lane `ship`
- `recovery`: `decision risk`, score 163, lane `ship`
- `stale`: `input pressure`, score 219, lane `ship`

## Note

The useful failure mode here is a wrong decision on a named case, not a vague style disagreement.
