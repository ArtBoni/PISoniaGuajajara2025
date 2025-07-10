using UnityEngine;

interface ISleepable
{
    public void Sleep();
}

public class Bed : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out ISleepable sleepable))
            sleepable.Sleep();
    }
}
