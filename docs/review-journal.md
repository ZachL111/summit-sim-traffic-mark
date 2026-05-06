# Review Journal

The repository goal stays the same: create a C# reference implementation for traffic workflows, centered on event replay, fixture event logs, and golden state snapshots. This note explains the added review angle.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 190, lane `ship`
- `stress`: `state drift`, score 145, lane `ship`
- `edge`: `review cost`, score 176, lane `ship`
- `recovery`: `decision risk`, score 235, lane `ship`
- `stale`: `input pressure`, score 235, lane `ship`

## Note

This file is intentionally plain so the fixture remains the source of truth.
