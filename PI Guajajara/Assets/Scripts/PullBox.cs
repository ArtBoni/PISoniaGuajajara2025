using Unity.VisualScripting;
using UnityEngine;

public class PullBox : MonoBehaviour
{
    [SerializeField] Transform sokobanObj;
    [SerializeField] GameObject sokobanInstance;
    [SerializeField] int distance;
    bool isNearBox = false;
    private void Start()
    {
        isNearBox = false;
    }

    private void Update()
    {



    }





    public void Sokoban()
    {
        if (Input.GetButton("Jump"))
        {
            isNearBox = true;

            if (isNearBox)
            {
                Vector3 direction = sokobanObj.position - transform.position;
                direction.y = 0; // Keep the movement in the horizontal plane
                direction.Normalize();
                sokobanObj.position += direction * distance * Time.deltaTime;
            }
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            sokobanInstance = collision.gameObject;
            sokobanObj = sokobanInstance.transform;
            isNearBox = true;
        }
    }
}   

