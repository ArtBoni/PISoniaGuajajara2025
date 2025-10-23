using System.Collections;
using TMPro;
using UnityEngine;

public class SlowWrite : MonoBehaviour
{
    [SerializeField] private TMP_Text textComponent;

    [SerializeField] private string fullText;
    [SerializeField] private float delayPerChar = 0.05f; // tempo entre cada letra
    [SerializeField] private bool playOnStart = true;

    private Coroutine typingCoroutine;

    private void Start()
    {
        if (playOnStart && textComponent != null)
            StartTyping(fullText);
    }

    public void StartTyping(string text)
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
             
        }

        typingCoroutine = StartCoroutine(TypeText(text));
    }

    private IEnumerator TypeText(string text)
    {
        textComponent.text = string.Empty;

        foreach (char c in text)
        {
            textComponent.text += c;
            yield return new WaitForSeconds(delayPerChar);
        }

        typingCoroutine = null;
    }

    public void Skip()
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
            typingCoroutine = null;
        }

        textComponent.text = fullText;
    }
}