using UnityEngine;

public class SleepingEnemyManager : MonoBehaviour
{
    [SerializeField] GameObject angryEnemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WakeUp()
    {
        gameObject.SetActive(false);
        angryEnemy.SetActive(true);
    }
}
