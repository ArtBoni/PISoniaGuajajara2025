using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
