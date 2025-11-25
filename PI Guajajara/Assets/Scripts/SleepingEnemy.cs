using System.Collections;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Events;

public interface ISleepyDamage
{
    void SleepyDamage();
}

public class SleepingEnemy : MonoBehaviour, IDamegabled
{
    [Header("Enemy Settings")]
    [SerializeField] private Transform target;
    [SerializeField] private int speed;

    [SerializeField] private int damage;

    [Header("Stun Settings")]
    [SerializeField] private float stunDuration = 1.5f; // quanto tempo fica atordoado

    [Header("Events")]
    [SerializeField] UnityEvent OnHit;

    float stunTimer = 0;
    Animator animator;

    [SerializeField] GameObject alarm;
    [SerializeField] GameObject alarmSound;
    bool isAngry = false;
    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isStun", false);
        
        //StopAngry();
    }

    private void Update()
    {

        // diminui o tempo de stun a cada frame
        if (animator.GetBool("isStun"))
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
        if (isAngry == true)
        {
            stunTimer = stunDuration;
            animator.SetBool("isStun", true);
            OnHit.Invoke();
        }

    }

    public void TurnAngry()
    {
        speed = 2;
        animator.SetBool("isSleeping", false);
        isAngry = true;
    }
    public void StopAngry()
    {
        speed = 0;
        animator.SetBool("isSleeping", true);
        isAngry = false;
    }

    public IEnumerator StopAngryTime()
    {
        yield return new WaitForSeconds(10);
        StopAngry();
        alarm.SetActive(false);
        alarmSound.SetActive(false);    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isAngry == true)
        {
            if (gameObject.TryGetComponent(out ISleepyDamage sleepyObj))
            {
                sleepyObj.SleepyDamage();
            }
        }
    }
}