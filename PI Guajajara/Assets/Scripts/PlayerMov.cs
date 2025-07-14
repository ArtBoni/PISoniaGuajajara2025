using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMov : MonoBehaviour
{
    [SerializeField] float speed;

    float horizontal, vertical;
    bool facing = true;
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

        
              

        if (horizontal > 0 && !facing)
            Flip();
        if (horizontal < 0 && facing)
            Flip();       
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal, vertical) * speed;
    }

   public void Flip()
   {
        facing = !facing;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
   }

    
}
