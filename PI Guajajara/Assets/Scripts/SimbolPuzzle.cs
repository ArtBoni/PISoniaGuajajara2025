using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SimbolPuzzle : MonoBehaviour
{
    Image simbol;
    [SerializeField] GameObject painel;
    [SerializeField] GameObject exitPanel;
    
    private void Start()
    {
        simbol = GetComponent<Image>();
        StartCoroutine(WaitColorToChange());
        painel.SetActive(false);
       
    }

    

    public IEnumerator WaitColorToChange()
    {
        float timeChenge = 2f;
        while (true) 
        {
            simbol.color = Random.ColorHSV();
            yield return new WaitForSeconds(timeChenge);
        }
              
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("Player"))
        {
            painel.SetActive(true);
        }
    }
}
