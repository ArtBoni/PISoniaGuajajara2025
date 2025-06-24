using UnityEngine;
using UnityEngine.Events;


public class GameController : MonoBehaviour
{
    [SerializeField] UnityEvent OnDialogue;    
    [SerializeField] UnityEvent OnPlaying;    
    public static GameController instance;
    
    void Awake()
    {
        instance = this;
    }     
}
