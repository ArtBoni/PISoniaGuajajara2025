using UnityEngine;

interface IBurnable
{
    public void Burning();
}
public class HouseBurn : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite burningHouses;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Burn()
    {
        spriteRenderer.sprite = burningHouses;
    }
}
