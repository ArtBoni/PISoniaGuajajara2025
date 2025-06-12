using UnityEngine;
using UnityEngine.Events;


public class NpcInteraction : TalkScript, IDialogue
{
    [SerializeField] GameObject dialogueBox;
    [SerializeField] private bool playerInRange;
    [SerializeField] UnityEvent OnInteract;

    public void StartDialgue()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            dialogueBox.SetActive(true);
        }
    }

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




    

    

