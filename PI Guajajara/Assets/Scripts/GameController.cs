using UnityEngine;
using UnityEngine.Events;

public enum Dialoguing 
{
    TALKING, PLAYING
}


public class GameController : MonoBehaviour
{
    [SerializeField]Dialoguing _gameState = Dialoguing.PLAYING;
    public static GameController instance;
    [SerializeField] UnityEvent OnPlaying, OnDialogue;

    NPCController npcController;
    public Dialoguing State { get => _gameState; set => _gameState = value; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        OnPlaying.AddListener(SetPlayingMode);
        OnDialogue.AddListener(SetTextMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetPlayingMode()
    {
        _gameState = Dialoguing.PLAYING;
    }

    void SetTextMode() 
    { 
        _gameState = Dialoguing.TALKING;
    }
}
