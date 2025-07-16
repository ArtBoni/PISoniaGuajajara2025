using UnityEngine;

public class PlayerSleep : MonoBehaviour, ISleepable
{
    [SerializeField] GameObject fadeIn;
    bool hasTalked;
    [SerializeField] GameObject player;
    private void Start() 
    { 
        hasTalked = false;
    }
    public void Sleep()
    {
        if(hasTalked)
        {
            player.SetActive(false);
            fadeIn.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Talk"))
        {
            hasTalked=true;
        }
    }
}
