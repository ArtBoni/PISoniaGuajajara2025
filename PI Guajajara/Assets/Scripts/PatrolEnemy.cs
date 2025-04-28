using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform targetPatrol;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(targetPatrol != null)
        {
            Vector2 moveInPatrol = (targetPatrol.position - transform.position).normalized;
        }
    }
}
