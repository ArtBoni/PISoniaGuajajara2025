using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SimbolPuzzle : MonoBehaviour
{
    Image simbol;
    private void Start()
    {
        simbol = GetComponent<Image>();
    }

    private void Update()
    {
        simbol.color = Random.ColorHSV();
    }

}
