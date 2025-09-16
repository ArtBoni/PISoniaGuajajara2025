using UnityEngine;

public class AngryEnemy : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            Vector2 direction= (target.position - transform.position).normalized;
            transform.position =  Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
