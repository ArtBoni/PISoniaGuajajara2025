using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Door : MonoBehaviour
{
    [SerializeField] Transform playerPos;
    [SerializeField] Transform teleportPos;
    Transform cameraPos;
    [SerializeField] Transform cameraTeleportPos;
    private void Start()
    {
        cameraPos = Camera.main.transform;
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerPos.transform.position = new Vector3(teleportPos.position.x, teleportPos.position.y, teleportPos.position.z);
            cameraPos.transform.position = new Vector3(cameraTeleportPos.position.x, cameraTeleportPos.position.y, cameraPos.position.z);
        }
    }
}
