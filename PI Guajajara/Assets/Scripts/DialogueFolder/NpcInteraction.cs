using UnityEngine;
using UnityEngine.Events;


public class NpcInteraction : TalkScript
{
    [SerializeField] GameObject dialogueBox;
    [SerializeField] UnityEvent OnInteract;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject)
        {
            OnInteract.Invoke();
        }
        
    }

    

    


}








