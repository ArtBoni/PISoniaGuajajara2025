using System.Collections;
using UnityEngine;

public class SimbolPuzzle : MonoBehaviour
{
    [SerializeField] GameObject[] simbolObj;
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
        simbolObj[simbolObj.Length - 1].transform.position = Input.mousePosition;
    }

    IEnumerator ChangeSimbols()
    {
        
        yield return new WaitForSeconds(waitToChangeOrder);
    }

}
