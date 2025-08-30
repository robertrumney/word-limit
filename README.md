# Word Limit Enforcer (Legacy InputField & TextMesh Pro)

A Unity component that limits input by **word count** instead of characters. Supports both the legacy `InputField` and TextMesh Pro `TMP_InputField`.

## Features
- Enforces a maximum word count in real time
- Works with either legacy UI or TextMesh Pro
- Optional serialized references or automatic component detection

## Setup
1. Add the script to the same GameObject as your input component.
2. If using TextMesh Pro, ensure the package is installed and define the `TMP_PRESENT` scripting symbol in Player Settings.
3. Optionally assign the input field references in the Inspector.

## Usage
- Set the desired word limit in the Inspector.
- The input will be trimmed to the limit as soon as it is exceeded.

## Notes
- If both legacy and TMP inputs are present, both will be governed by the same limit.
- Trimming occurs on whitespace-delimited words.

## License
MIT
