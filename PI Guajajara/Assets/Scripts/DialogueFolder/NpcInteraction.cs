using UnityEngine;
using UnityEngine.Events;


public class NpcInteraction : TalkScript, IInteractable
{
    [SerializeField] UnityEvent OnInteract;
    public void Interact()
    {
        Collider2D npcCollider = GetComponent<Collider2D>();
        if (npcCollider != null)
        {
            OnInteract.Invoke();
        }
    }
}




    

    

