using UnityEngine;
using UnityEngine.Events;

public class pressButton : MonoBehaviour
{
    public UnityEvent buttonPressed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        buttonPressed.Invoke();
    }
}
