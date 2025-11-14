using System.Collections;
using UnityEngine;
using UnityEngine.Events;
public class Elevator : MonoBehaviour
{
    [SerializeField] GameObject barrier;
    [SerializeField] float rideTime;
    bool canActivate;
    public UnityEvent playDoorAnims;
    public UnityEvent playElevatorAnims;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canActivate == true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                StartCoroutine(StartRide());
                barrier.SetActive(true);
                playDoorAnims.Invoke();
                canActivate = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            canActivate = true;
        }
    }
    public IEnumerator StartRide()
    {
        yield return new WaitForSeconds(rideTime);
        print("Working");   
        playElevatorAnims.Invoke();
    }
}
