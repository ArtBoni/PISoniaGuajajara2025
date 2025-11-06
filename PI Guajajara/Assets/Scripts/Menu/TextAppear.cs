using JetBrains.Annotations;
using System.Collections;
using System.Xml;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlowWrite : MonoBehaviour
{
    [SerializeField] private TMP_Text textComponent;
    [SerializeField] GameObject fadeOut;
    [SerializeField] private string fullText;
    [SerializeField] private float delayPerChar = 0.05f; // tempo entre cada letra
    [SerializeField] private bool playOnStart = true;
    [SerializeField] string[] texts;
    int currentSection;
    [SerializeField] GameObject currentBg;
    [SerializeField] GameObject[] backgrounds;
    SlowWrite instance;
    private Coroutine typingCoroutine;

    private void Start()
    {
        instance = this;
        currentBg = backgrounds[currentSection = 0];
        currentBg.SetActive(true);
        if (playOnStart && textComponent != null)
            StartTyping(fullText);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (currentSection <= 3)
            {
                fullText = texts[currentSection += 1];
                currentBg = backgrounds[currentSection];
                fadeOut.SetActive(false);
                fadeOut.SetActive(true);
                StartCoroutine(StartText());
            }
            if (currentSection >= 3)
            {
                StartCoroutine(LoadLevel());
                if (currentSection >= 4)
                {
                    SceneManager.LoadScene("FirstFloor");
                }
            }
        }
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
    public IEnumerator StartText()
    {
        yield return new WaitForSeconds(2);
        currentBg.SetActive(true);
        backgrounds[currentSection - 1].SetActive(false);
        StartTyping(fullText);
    }
    public IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene("FirstFloor");
    }
}