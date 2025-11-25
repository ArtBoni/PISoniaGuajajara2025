using UnityEngine;
using UnityEngine.Events;

public class AngryEnemy : MonoBehaviour, IDamegabled
{
    [Header("Enemy Settings")]
    [SerializeField] private Transform target;
    [SerializeField] private float speed;
   
    [SerializeField] private float damage = 10;

    [Header("Stun Settings")]
    [SerializeField] private float stunDuration = 1.5f; // quanto tempo fica atordoado

    [Header("Events")]
    [SerializeField] UnityEvent OnHit;

    float stunTimer = 0;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isStun", false);
        //StopAngry();
    }

    private void Update()
    {
        
        // diminui o tempo de stun a cada frame
        if(animator.GetBool("isStun"))
            stunTimer -= Time.deltaTime;

        // se o transform não for nulo ele persegue o alvo
        if (target != null && !animator.GetBool("isStun"))
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if (stunTimer <= 0)
        {
            animator.SetBool("isStun", false);
        }
    }

    public void Hit(float damage)
    {
        
        // aplica stun sempre que leva dano
        stunTimer = stunDuration;
        animator.SetBool("isStun", true);
        OnHit.Invoke();

       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMov>(out PlayerMov player))
        {
            player.TakeDamage(1);
            Debug.Log("Inimigo causou dano no player!");
        }
    }

    public void TurnAngry()
    {
        speed = 2;
    }
    public void StopAngry()
    {
        speed = 0;
    }
}