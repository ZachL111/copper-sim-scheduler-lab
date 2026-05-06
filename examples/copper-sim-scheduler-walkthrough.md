# Copper Sim Scheduler Lab Walkthrough

The fixture is intentionally compact, so the review starts with the cases that pull farthest apart.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 149 | ship |
| stress | state drift | 88 | hold |
| edge | review cost | 199 | ship |
| recovery | decision risk | 163 | ship |
| stale | input pressure | 219 | ship |

Start with `stale` and `stress`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

If `stress` becomes less cautious without a clear reason, I would inspect the drag input first.
