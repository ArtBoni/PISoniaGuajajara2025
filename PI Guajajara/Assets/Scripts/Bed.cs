using UnityEngine;

interface ISleepable
{
    public void Sleep();
}

public class Bed : MonoBehaviour
{
    [SerializeField] GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        if (collision.gameObject.player)
        {

        }*/
    }
}
