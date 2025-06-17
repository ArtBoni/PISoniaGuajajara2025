using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform movePosition;
    Transform cameraPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraPosition = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cameraPosition.position = new Vector3(movePosition.position.x, movePosition.position.y, cameraPosition.position.z);
        }
    }
}