using UnityEngine;
using UnityEngine.Events;
public class LaserHitbox : MonoBehaviour
{
    public UnityEvent laserActive;
    public GameObject alarms;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            laserActive.Invoke();
            alarms.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
