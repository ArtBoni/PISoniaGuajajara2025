using UnityEngine;
using UnityEngine.Events;

public abstract class NPCController : MonoBehaviour
{
    [SerializeField] UnityEvent OnTalk;
    
    public DialogueController dialogueController;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogueController = GetComponent<DialogueController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OnTalk.AddListener(StartDialogue); 
                print("Funcionou");
            }
        }
        
        
    }


    public void StartDialogue()
    {
      OnTalk.Invoke();
    }
}
