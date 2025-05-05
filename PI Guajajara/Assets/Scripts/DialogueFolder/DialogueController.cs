using UnityEngine;
using TMPro;
using System.Collections;
using System;

public class DialogueController : MonoBehaviour
{
    public Action TypeFinished;
    [SerializeField] float typeDelay = 5f;
    public TextMeshProUGUI textObj;

    public string fullText;

    Coroutine coroutine;

    void Start()
    {
        StartCoroutine(StartTyping());
    }


    public IEnumerator StartTyping()
    {
        textObj.text = fullText;
        textObj.maxVisibleCharacters = 0;
        for (int i = 0; i < textObj.text.Length; i++)
        {
            textObj.maxVisibleCharacters = i;
            yield return new WaitForSeconds(typeDelay);

        }

        TypeFinished?.Invoke();
    }

    public void Skip()
    {
        StopCoroutine(coroutine);
        textObj.maxVisibleCharacters = textObj.text.Length;
    }

}
