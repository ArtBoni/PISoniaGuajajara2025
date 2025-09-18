using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SimbolPuzzle : MonoBehaviour
{
    Image simbol;
    [SerializeField] GameObject panel;
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

}
