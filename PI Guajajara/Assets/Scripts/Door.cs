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
        if (collision.gameObject.CompareTag("Player"))
        {
            playerPos = teleportPos;
            cameraPos = cameraTeleportPos;
        }
    }
}
