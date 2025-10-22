using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;

public class TalkScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;
    [SerializeField] GameObject dialoguePanel;
    [SerializeField] string[] lines;
    [SerializeField] float textSpeed = 0.05f;

    int index;
    bool isTyping = false;

    void OnEnable()
    {
        // Quando o painel é ativado, começa o diálogo
        StartDialogue();
    }

    void OnDisable()
    {
        // Quando o painel é desativado, reseta tudo
        ResetDialogue();
    }

    void Update()
    {
        if (!dialoguePanel.activeSelf)
            return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isTyping)
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
                isTyping = false;
            }
            else
            {
                NextLine();
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        textComponent.text = string.Empty;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        isTyping = true;
        textComponent.text = string.Empty;

        foreach (char c in lines[index])
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

        isTyping = false;
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            StartCoroutine(TypeLine());
        }
        else
        {
            index = -1;
            dialoguePanel.SetActive(false);
        }  
    }

    void ResetDialogue()
    {
        StopAllCoroutines();
        textComponent.text = string.Empty;
        index = 0;
        isTyping = false;
    }


}

