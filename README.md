# summit-sim-traffic-mark

`summit-sim-traffic-mark` is a compact C# repository for simulations, centered on this goal: Create a C# reference implementation for traffic workflows, centered on event replay, fixture event logs, and golden state snapshots.

## Purpose

I want this repository to be useful as a quick reading exercise: fixtures first, implementation second, verifier last.

## Summit Sim Traffic Mark Review Notes

`recovery` and `stress` are the cases worth reading first. They show the optimistic and cautious ends of the fixture.

## What Is Covered

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/summit-sim-traffic-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `decision risk` and `state drift`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Implementation Notes

The core code exposes a scoring path and the added review layer uses `signal`, `slack`, `drag`, and `confidence`. The domain terms are `input pressure`, `state drift`, `review cost`, and `decision risk`.

The C# implementation avoids hidden state so fixture changes are easy to reason about.

## Command

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Audit Path

The verifier is intentionally local. It should fail if the fixture score math, lane assignment, or language-specific test drifts.

## Limits

No external service is required. A deeper version would add more negative cases and a clearer boundary around invalid input.
