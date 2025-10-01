using UnityEngine;

public class AngryEnemy : MonoBehaviour, IDamegabled
{
    [Header("Enemy Settings")]
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float maxLife = 20f;

    [Header("Stun Settings")]
    [SerializeField] private float stunDuration = 1.5f; // quanto tempo fica atordoado

    private float currentLife;
    private float stunTimer = 0f;

    private void Start()
    {
        currentLife = maxLife;
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
        currentLife -= damage;

        // aplica stun sempre que leva dano
        stunTimer = stunDuration;

        if (currentLife <= 0)
        {
            Destroy(gameObject);
        }
    }
}