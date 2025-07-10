using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMov : MonoBehaviour
{
    [SerializeField] float speed;
    

    float horizontal, vertical;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical).normalized;
        
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal, vertical) * speed;
    }

   public void Flip()
   {
        
   }
}
