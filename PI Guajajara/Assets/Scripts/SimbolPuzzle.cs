using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SimbolPuzzle : MonoBehaviour
{
    private Image simbol;
    private Button simbolsBTN;


    private void Start()
    {
        simbol = GetComponent<Image>();
        simbolsBTN = GetComponent<Button>();
        StartCoroutine(ChangeColor(2f));
    }

    public IEnumerator ChangeColor(float timeChange)
    {
        
        while (true)
        {
            simbol.color = Random.ColorHSV();
            yield return new WaitForSeconds(timeChange);
        }

           
    }


    private void OnMouseDown()
    {
        
    }


}
