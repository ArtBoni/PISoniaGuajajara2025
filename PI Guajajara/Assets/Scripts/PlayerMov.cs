using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))] 
[RequireComponent(typeof(Rigidbody2D))] 
public class PlayerMov : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] SpriteRenderer spriteRenderer;

    float moveX;
    float moveY;
    float horizontal, vertical;
    bool facingX = true;
    bool facingY = true;
   
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
        moveX = Input.GetAxisRaw("Horizontal"); 
        moveY = Input.GetAxisRaw("Vertical");
        /*Vector2 moveDirection = new Vector2 (horizontal, vertical).normalized;
        
        if(moveDirection.magnitude >= 0)
        {
            return;
        }
        */

        if (moveX > 0 && !facingX)
            FlipX();

        if (moveX < 0 && facingX)
            FlipX();
        
           

        if (moveY > 0 && !facingY)
            FlipY();
        
        if(moveY < 0 && facingY)
            FlipY();



       
        
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2 (horizontal, vertical) * speed;
    }

    void FlipX()
    {
        facingX = !facingX;
        Vector3 theScaleX = transform.localScale;
        theScaleX.x *= -1;
        transform.localScale = theScaleX;
    }

    void FlipY()
    {
        facingY = !facingY;
        Vector3 theScale = transform.localScale;
        theScale.y *= -1;
        transform.localScale = theScale;
    }
}
