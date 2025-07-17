using UnityEngine;

public class ResetButton : MonoBehaviour
{
    [SerializeField] Transform objPos;
    Transform objOgPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objOgPos = objPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        objPos = objOgPos;
    }
}
