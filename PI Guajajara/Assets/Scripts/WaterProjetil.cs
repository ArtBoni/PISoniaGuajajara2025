using UnityEngine;

public class WaterProjetil : MonoBehaviour
{
    [SerializeField] int velocity = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, .5f);
    }
}
