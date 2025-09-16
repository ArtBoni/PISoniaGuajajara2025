/*using UnityEngine;

public class StunObject : MonoBehaviour, IHit
{
    Rigidbody2D rb;
    [Min(1)] float timer;
    IHit hittable;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == true) 
        {
            Hit(5f);
        }
    }
        

    public void Hit(float timer)
    {
        this.timer = timer;
        timer--;
        rb.angularVelocity = 0;
        if (timer == 0f)
        {
            rb.angularVelocity = 1;
        }
    }
}
*/