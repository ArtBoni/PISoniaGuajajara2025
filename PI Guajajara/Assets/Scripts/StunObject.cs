using UnityEngine;

public class StunObject : MonoBehaviour, IStun
{
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void StunEnemy()
    {
        rb.angularVelocity = 0;        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == true) 
        {
            StunEnemy();
        }
    }


}
