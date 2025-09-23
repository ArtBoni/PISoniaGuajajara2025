using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SimbolPuzzle : MonoBehaviour
{
    Image simbol;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject openObj;
    private void Start()
    {
        simbol = GetComponent<Image>();
        StartCoroutine(WaitColorToChange());
        panel.SetActive(false);
    }

    private void Update()
    {

    }

    public IEnumerator WaitColorToChange()
    {
        float timeChenge = 0f;
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
            print("Funciona");
        }
    }

}
