using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class WordLimitEnforcer : MonoBehaviour
{
    public int wordLimit = 10;
    private InputField inputField;

    private void Awake()
    {
        inputField = GetComponent<InputField>();
        inputField.onValueChanged.AddListener(EnforceWordLimit);
    }

    private void EnforceWordLimit(string text)
    {
        string[] words = text.Split(new char[] { ' ', '\n', '\t' }, System.StringSplitOptions.RemoveEmptyEntries);
        if (words.Length > wordLimit)
        {
            inputField.onValueChanged.RemoveListener(EnforceWordLimit);
            inputField.text = string.Join(" ", words, 0, wordLimit);
            inputField.onValueChanged.AddListener(EnforceWordLimit);
        }
    }
}
