using UnityEngine;

public class PlayerSleep : MonoBehaviour, ISleepable
{
    [SerializeField] GameObject fadeIn;
    bool hasTalked;
    [SerializeField] GameObject player;
    SpriteRenderer spriteRenderer;
    [SerializeField] static Sprite burningHouse;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        hasTalked = false;
    }
    public void Sleep()
    {
        if(hasTalked)
        {
            player.SetActive(false);
            Instantiate(fadeIn);
            spriteRenderer.sprite = burningHouse;
        }
    }
}
