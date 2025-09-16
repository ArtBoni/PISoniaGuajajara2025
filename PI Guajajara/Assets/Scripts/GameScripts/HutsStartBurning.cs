using UnityEngine;

public class HutsStartBurning : MonoBehaviour
{
    [SerializeField] SpriteRenderer hut;
    [SerializeField] SpriteRenderer triangleHut;
    static SpriteRenderer hutChange;
    static SpriteRenderer triangleHutChange;
    [SerializeField] Sprite burningHut;
    [SerializeField] Sprite burningTriangleHut;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        hutChange = hut;
        triangleHutChange = triangleHut;
    }
    public void ChangeSprite()
    {
        
    }
}
