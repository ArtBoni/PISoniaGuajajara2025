using UnityEngine;
using UnityEngine.Events;


public class NpcInteraction : TalkScript
{
    [SerializeField] GameObject dialogueBox;
    [SerializeField] private bool playerInRange = false;
    [SerializeField] UnityEvent OnInteract;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && Input.GetKeyDown(KeyCode.Mouse0))
        {            
            playerInRange = true;
            dialogueBox.SetActive(true);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {        
        playerInRange = false;
        dialogueBox.SetActive(false);
    }



}




    

    

