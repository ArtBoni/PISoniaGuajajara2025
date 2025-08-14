using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public UnityEvent OnDialoguing;
    public UnityEvent OnPlaying;
    public UnityEvent OnPause;
    public UnityEvent OnUnPause;


    void Awake()
    {
        instance = this;
    }

    
}
