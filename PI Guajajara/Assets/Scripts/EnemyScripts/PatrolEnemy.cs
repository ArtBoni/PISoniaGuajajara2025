using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class PatrolEnemy : MonoBehaviour
{
   [SerializeField] Transform[] patrolPoints;
   [SerializeField] float moveSpeed, reachDistance, waitTimeAtPoint;
   [SerializeField] Transform target;
    
    int currentPointIndex = 0;   
    Rigidbody2D rb;
    bool isWaiting = false;     

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (patrolPoints.Length > 0)
        {
            transform.position = patrolPoints[currentPointIndex].position;
        }
    }

    private void Update()
    {
        if(target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
        
    }

    void FixedUpdate()
    {
        if (!isWaiting)
        {
            Patrol();
        }
    }

    void Patrol()
    {
        if (patrolPoints.Length == 0) return;

        Vector2 direction = (patrolPoints[currentPointIndex].position - transform.position).normalized;
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);

        float distance = Vector2.Distance(transform.position, patrolPoints[currentPointIndex].position);
        if (distance <= reachDistance)
        {
            StartCoroutine(WaitBeforeNextPoint());
        }
    }

    IEnumerator WaitBeforeNextPoint()
    {
        isWaiting = true;

        yield return new WaitForSeconds(waitTimeAtPoint);

        currentPointIndex++;
        if (currentPointIndex >= patrolPoints.Length)
        {
            currentPointIndex = 0;
        }

        isWaiting = false;
    }
}
