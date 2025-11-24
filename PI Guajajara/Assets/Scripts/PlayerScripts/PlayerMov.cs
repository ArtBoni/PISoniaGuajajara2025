using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMov : MonoBehaviour
{
    [SerializeField] private HudDoPlayer hud;
    [SerializeField] private float speed = 5f;
    [SerializeField] private UnityEvent OnPause;
    [SerializeField] private UnityEvent OnUnPause;
    [SerializeField] float currentLife;
    public float MaxLife => maxlife;
    public float CurrentLife => currentLife;

    private float horizontal, vertical;
    private bool isPaused;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private Rigidbody2D rb;
    float maxlife = 3;
    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        isPaused = false;
        currentLife = 3;
        maxlife = 3;
        hud.UpdateLife((int)currentLife, (int)maxlife);
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        animator.SetBool("isWalking", horizontal != 0 || vertical != 0);
        spriteRenderer.flipX = horizontal < 0;      
        



        if (Input.GetButtonDown("Cancel"))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                OnUnPause?.Invoke();
            }
            else
            {
                Time.timeScale = 0;
                OnPause?.Invoke();
            }
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal, vertical) * speed;
    }

   public void Pause()
    {
        
        if (Input.GetButton("Escape"))
        {
            isPaused = !isPaused;
            OnPause.Invoke();
            Time.timeScale = 0;
        }
        else
        {
            isPaused = false;
            OnUnPause.Invoke();
            Time.timeScale = 1;
        }
    }
    public void TakeDamage(int amount)
    {
        currentLife -= amount;
        hud.UpdateLife((int)currentLife, (int)maxlife);

        if (currentLife <= 0)
        {
            currentLife = 0;
            Debug.Log("PLAYER MORREU!");
        }
    }
}