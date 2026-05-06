# Summit Sim Traffic Mark Walkthrough

The fixture is intentionally compact, so the review starts with the cases that pull farthest apart.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 190 | ship |
| stress | state drift | 145 | ship |
| edge | review cost | 176 | ship |
| recovery | decision risk | 235 | ship |
| stale | input pressure | 235 | ship |

Start with `recovery` and `stress`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

If `stress` becomes less cautious without a clear reason, I would inspect the drag input first.
