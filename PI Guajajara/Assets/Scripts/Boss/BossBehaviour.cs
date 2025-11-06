using UnityEngine;



public class BossBehaviour : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 3f;
    

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

    }
}
