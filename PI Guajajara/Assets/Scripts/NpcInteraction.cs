using UnityEngine;
using UnityEngine.Events;


public class NpcInteraction : TalkScript
{
    [SerializeField] UnityEvent OnInteract;
    [SerializeField] UnityEvent OnDialogueEnd;

    
         private void OnTriggerEnter2D(Collider2D collision)
         {
             if(collision.gameObject)
             {
                  OnInteract.Invoke();
             }
        
         }

        private void OnTriggerExit2D(Collider2D collision)
        {
            OnDialogueEnd.Invoke();
        }






}








