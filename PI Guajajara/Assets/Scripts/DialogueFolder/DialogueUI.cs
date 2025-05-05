using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class DialogueUI : MonoBehaviour
{
    Image background;
    TextMeshProUGUI nameTxt, talkTxt;

    [SerializeField] float speed = 10f;
    bool open = false;

    private void Awake()
    {
        background = transform.GetChild(0).GetComponent<Image>();
        nameTxt = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        talkTxt = transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (open)
        {
            background.fillAmount = Mathf.Lerp(background.fillAmount, 1, speed * Time.deltaTime);
        }
        else
        {
            background.fillAmount = Mathf.Lerp(background.fillAmount, 0, speed * Time.deltaTime);

        }
    }

    public void SetName(string name)
    {
        nameTxt.text = name;
    }

    public  void Enable()
    {
        background.fillAmount = 0;
        open = true;
    }
    public void Disable() 
    {
        open = false;
        nameTxt.text = "";
        talkTxt.text = "";
    }

}
