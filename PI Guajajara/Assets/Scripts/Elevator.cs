using System.Collections;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField] GameObject barrier;
    [SerializeField] float rideTime;
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
            barrier.SetActive(true);
            StartCoroutine(StartRide());
        }
    }
    public IEnumerator StartRide()
    {
        yield return new WaitForSeconds(rideTime);
        barrier.SetActive(false);
    }
}
