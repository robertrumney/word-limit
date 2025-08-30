using UnityEngine;
using UnityEngine.UI;
#if TMP_PRESENT
using TMPro;
#endif

public class WordLimitEnforcer : MonoBehaviour
{
    public int wordLimit = 10;
    public InputField legacyInput;
#if TMP_PRESENT
    public TMP_InputField tmpInput;
#endif

    void Awake()
    {
        if (!legacyInput) legacyInput = GetComponent<InputField>();
#if TMP_PRESENT
        if (!tmpInput) tmpInput = GetComponent<TMP_InputField>();
#endif
    }

    void OnEnable()
    {
        if (legacyInput) legacyInput.onValueChanged.AddListener(EnforceWordLimitLegacy);
#if TMP_PRESENT
        if (tmpInput) tmpInput.onValueChanged.AddListener(EnforceWordLimitTMP);
#endif
    }

    void OnDisable()
    {
        if (legacyInput) legacyInput.onValueChanged.RemoveListener(EnforceWordLimitLegacy);
#if TMP_PRESENT
        if (tmpInput) tmpInput.onValueChanged.RemoveListener(EnforceWordLimitTMP);
#endif
    }

    void EnforceWordLimitLegacy(string text)
    {
        var words = text.Split(new char[] { ' ', '\n', '\t' }, System.StringSplitOptions.RemoveEmptyEntries);
        if (words.Length > wordLimit)
        {
            legacyInput.onValueChanged.RemoveListener(EnforceWordLimitLegacy);
            legacyInput.text = string.Join(" ", words, 0, wordLimit);
            legacyInput.onValueChanged.AddListener(EnforceWordLimitLegacy);
        }
    }

#if TMP_PRESENT
    void EnforceWordLimitTMP(string text)
    {
        var words = text.Split(new char[] { ' ', '\n', '\t' }, System.StringSplitOptions.RemoveEmptyEntries);
        if (words.Length > wordLimit)
        {
            tmpInput.onValueChanged.RemoveListener(EnforceWordLimitTMP);
            tmpInput.text = string.Join(" ", words, 0, wordLimit);
            tmpInput.onValueChanged.AddListener(EnforceWordLimitTMP);
        }
    }
#endif
}
