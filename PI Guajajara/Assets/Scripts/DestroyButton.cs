using UnityEngine;

public class DestroyButton : MonoBehaviour
{
    [SerializeField] GameObject destroyable;
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite buttonUnpressed;
    [SerializeField] Sprite buttonPressed;
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
        if (collision.gameObject)
        {
            destroyable.SetActive(false);
            spriteRenderer.sprite = buttonPressed;
        }
    }
}
