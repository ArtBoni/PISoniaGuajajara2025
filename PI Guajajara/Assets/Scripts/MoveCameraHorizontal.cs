using UnityEngine;

public class MoveCameraHorizontal : MonoBehaviour
{
    [SerializeField] float horizontal;
    static float moveLengthX;
    [SerializeField] float screenLengthX = 18;
    Transform cameraPosX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraPosX = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            moveLengthX += screenLengthX * horizontal;
            cameraPosX.transform.position = new Vector3(moveLengthX, cameraPosX.position.y, cameraPosX.position.z);
        }
    }
}
