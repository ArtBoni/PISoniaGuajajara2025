using UnityEngine;

public class StunObject : MonoBehaviour, IStun
{
    Rigidbody2D rb;
    [Min(1)] float timer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == true) 
        {
            StunEnemy(5f);
        }
    }

    public void StunEnemy(float timer)
    {
        this.timer = timer;
        timer--;
        rb.angularVelocity = 0;
        if(timer == 0f)
        {
            rb.angularVelocity = 1;
        }
    }
}
