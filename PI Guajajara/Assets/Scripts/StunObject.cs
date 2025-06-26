using UnityEngine;

public class StunObject : MonoBehaviour, IStun
{
    public void StunEnemy()
    {
        Vector2 movement = Vector2.negativeInfinity;
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == true) 
        {
            StunEnemy();
        }
    }


}
