# Word Limit Enforcer for Unity UI InputField

This Unity script limits the number of **words** (not characters) a user can enter into a standard `InputField`.

## Features

- Works with Unity's legacy `InputField` (not TextMeshPro).
- Enforces a maximum word count in real-time.
- Automatically trims extra words beyond the limit.

## How to Use

1. Attach the `WordLimitEnforcer` script to any GameObject with an `InputField` component.
2. Set the desired `wordLimit` in the Inspector.
