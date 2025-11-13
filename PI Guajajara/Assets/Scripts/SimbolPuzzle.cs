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
        simbolsBTN.onClick.AddListener(() => OnMouseDown());
    }

    public IEnumerator ChangeColor(float timeChange)
    {
        timeChange = 2f;
        yield return new WaitForSeconds(timeChange);
        simbol.color = Random.ColorHSV();
    }   

    private void OnMouseDown()
    {
        StopAllCoroutines();
    }
}
