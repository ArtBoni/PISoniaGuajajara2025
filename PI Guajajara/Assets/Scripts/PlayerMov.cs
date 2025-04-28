using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))] 
[RequireComponent(typeof(Rigidbody2D))] 
public class PlayerMov : MonoBehaviour
{
    [SerializeField] float  horizontal, vertical, speed;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        Vector2 moveDirection = new Vector2 (horizontal, vertical).normalized;
        
        if(moveDirection.magnitude >= 0)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2 (horizontal, vertical) * speed;
    }
}
