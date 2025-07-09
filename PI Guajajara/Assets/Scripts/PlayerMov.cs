using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))] 
[RequireComponent(typeof(Rigidbody2D))] 
public class PlayerMov : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] SpriteRenderer spriteRenderer;

    float move;
    float horizontal, vertical;
    bool facingX = true;
   
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
        move = Input.GetAxisRaw("Horizontal"); Input.GetAxisRaw("Vertical");
        /*Vector2 moveDirection = new Vector2 (horizontal, vertical).normalized;
        
        if(moveDirection.magnitude >= 0)
        {
            return;
        }
        */

        if (move > 0 && !facingX)
            Flip();
        
        if(move < 0 && facingX)
           Flip();
        
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2 (horizontal, vertical) * speed;
    }

    void Flip()
    {
        facingX = !facingX; 
        Vector3 theScale = transform.localScale;
        theScale.x *= -1; theScale.y *= -1;
        transform.localScale = theScale;
    }
}
