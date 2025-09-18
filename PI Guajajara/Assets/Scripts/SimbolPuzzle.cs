using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SimbolPuzzle : MonoBehaviour
{
    [SerializeField] Image[] simbolObj;
    [SerializeField] GameObject painelSimbol;
    [SerializeField] GameObject openObj;
    [SerializeField] float corectOrder;
    [SerializeField] int waitToChangeOrder;
    bool isCorrect = false;

    private void Start()
    {
        painelSimbol.SetActive(false);
        isCorrect = false;
        ChangeSimbols();
    }

    private void Update()
    {
        simbolObj[simbolObj.Length - 1].transform.SetAsFirstSibling();
    }

    IEnumerator ChangeSimbols()
    {
        yield return new WaitForSeconds(waitToChangeOrder);
    }

}
