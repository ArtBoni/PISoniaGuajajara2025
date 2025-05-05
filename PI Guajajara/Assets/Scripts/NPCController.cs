using UnityEngine;
using UnityEngine.UI;

public abstract class NPCController : MonoBehaviour
{
    [SerializeField] RawImage NpcFace;

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
        StartDialog();
    }


    public void StartDialog()
    {

    }
}
