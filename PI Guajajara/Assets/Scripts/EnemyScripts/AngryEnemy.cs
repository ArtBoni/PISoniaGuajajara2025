using UnityEngine;
using UnityEngine.Events;

public class AngryEnemy : MonoBehaviour, IDamegabled
{
    [Header("Enemy Settings")]
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 2f;
   
    [SerializeField] private float damage = 10f;

    [Header("Stun Settings")]
    [SerializeField] private float stunDuration = 1.5f; // quanto tempo fica atordoado

    [Header("Events")]
    [SerializeField] UnityEvent OnHit;

    float stunTimer = 0f;

    private void Start()
    {
        
    }

    private void Update()
    {
        
        // diminui o tempo de stun a cada frame
        if (stunTimer > 0)
        {
            stunTimer -= Time.deltaTime;
            return; // enquanto estiver stunado não se move
        }

        // se o transform não for nulo ele persegue o alvo
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    public void Hit(float damage)
    {
        
        // aplica stun sempre que leva dano
        stunTimer = stunDuration;
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



}