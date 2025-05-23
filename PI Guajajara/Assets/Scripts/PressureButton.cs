using UnityEngine;

public class PressureButton : MonoBehaviour
{
    [SerializeField] GameObject destroyableObject;
    SpriteRenderer spriteRenderer;
    [SerializeField] SpriteRenderer buttonActive;
    [SerializeField] SpriteRenderer buttonInactive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject)
        {
            destroyableObject.SetActive(false);
            spriteRenderer = buttonActive;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            destroyableObject.SetActive(true);
            spriteRenderer = buttonInactive;
        }
    }
}
