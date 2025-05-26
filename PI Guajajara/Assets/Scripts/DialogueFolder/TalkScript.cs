using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;

public abstract class TalkScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;

    [SerializeField] string[] lines;
    [SerializeField] float textSpeed;

    int index;
    bool isTyping = false;
    [SerializeField] GameObject dialogueBox; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {            
            if(isTyping) 
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
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        isTyping = true;
        textComponent.text = string.Empty;
        foreach (char c in lines[index].ToCharArray())
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
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
        }   
        
    }

    
}

