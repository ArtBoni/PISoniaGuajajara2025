using UnityEngine;

public class PressureButton : MonoBehaviour
{
    [SerializeField] GameObject destroyableObject;
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite buttonActive;
    [SerializeField] Sprite buttonInactive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
            spriteRenderer.sprite = buttonActive;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            destroyableObject.SetActive(true);
            spriteRenderer.sprite = buttonInactive;
        }
    }
}
