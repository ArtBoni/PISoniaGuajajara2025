using UnityEngine;

public class StopSliding : MonoBehaviour
{
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            new Vector2(0, 0);
        }
    }
}
