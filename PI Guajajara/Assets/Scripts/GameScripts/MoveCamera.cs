using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    Transform cameraPos;
    [SerializeField] Transform cameraMovePoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraPos = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cameraPos.transform.position = new Vector3(cameraMovePoint.position.x, cameraMovePoint.position.y, cameraPos.position.z);
        }
    }
}
