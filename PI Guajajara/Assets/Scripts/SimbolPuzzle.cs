using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SimbolPuzzle : MonoBehaviour
{
    Image simbol;
    [SerializeField] GameObject painel;
    
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            painel.SetActive(true);
        }
    }
}
