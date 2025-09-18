using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SimbolPuzzle : MonoBehaviour
{
    Image simbol;
    private void Start()
    {
        simbol = GetComponent<Image>();
        StartCoroutine(WaitColorToChange());


    }

    private void Update()
    {
    }

  public IEnumerator WaitColorToChange()
  {
        float timeChenge = .5f;
        while (true) {
            simbol.color = Random.ColorHSV();
            yield return new WaitForSeconds(timeChenge);
        }

        
  }

}
