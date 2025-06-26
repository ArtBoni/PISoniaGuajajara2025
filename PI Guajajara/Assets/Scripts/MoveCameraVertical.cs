using UnityEngine;

public class MoveCameraVertical : MonoBehaviour
{
    [SerializeField] float vertical;
    static float moveLengthY;
    [SerializeField] float screenLengthY = 10;
    Transform cameraPosY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraPosY = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            moveLengthY += screenLengthY * vertical;

            cameraPosY.transform.position = new Vector3(cameraPosY.position.x, moveLengthY, cameraPosY.position.z);
        }
    }
}
