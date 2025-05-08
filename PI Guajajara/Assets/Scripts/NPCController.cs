using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class NPCController : MonoBehaviour
{
    public UnityEvent OnTalk;
    [SerializeField] Transform playerPosition;

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
        if (Mathf.Abs(transform.position.x - playerPosition.position.x) < 2.0f)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartDialog();
                print("Funcionou");
            }
        }
        
        
    }


    public void StartDialog()
    {
        
    }
}
