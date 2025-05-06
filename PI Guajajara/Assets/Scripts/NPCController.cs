using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class NPCController : MonoBehaviour
{
    public UnityEvent OnTalk;
    [SerializeField] Transform npcPosition;

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
        if (collision.gameObject.Equals("Player"))
        {
            StartDialog();
        }
        
    }


    public void StartDialog()
    {
        OnTalk.Invoke();
    }
}
