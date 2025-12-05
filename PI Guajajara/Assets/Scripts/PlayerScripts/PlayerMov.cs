using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMov : MonoBehaviour, ISleepyDamage
{
    [SerializeField] private HudDoPlayer hud;
    [SerializeField] private float speed = 5f;
    [SerializeField] private UnityEvent OnPause;
    [SerializeField] private UnityEvent OnUnPause;

    private float horizontal, vertical;
    private bool isPaused;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private Rigidbody2D rb;
    float maxlife = 3;

    [SerializeField] Joystick moveJoyStick;
    Vector2 movement;
    void Start()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        isPaused = false;
    }

    void Update()
    {
        if(moveJoyStick != null)
        {
            horizontal = Input.GetAxis("Horizontal") + moveJoyStick.Horizontal;
            vertical = Input.GetAxis("Vertical") + moveJoyStick.Vertical;
        }
        movement = movement.normalized;
        //horizontal = Input.GetAxisRaw("Horizontal");
        //vertical = Input.GetAxisRaw("Vertical");
        animator.SetBool("isWalking", horizontal != 0 || vertical != 0);
        spriteRenderer.flipX = horizontal < 0;      
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            SleepyDamage();
        }


        if (Input.GetButtonDown("Cancel"))
        {
            if (Time.timeScale == 0)
            {
               
                OnUnPause?.Invoke();
            }
            else
            {
                
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
    public void SleepyDamage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}