using System.Collections;
using UnityEngine;

public class SequenceButton : MonoBehaviour
{
    [SerializeField] private int buttonID;
    [SerializeField] private SequencePuzzle puzzle;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            puzzle.PressButton(buttonID);
            Debug.Log("Button " + buttonID + " pressed");
        }
    }

    public IEnumerator ChangeButtonColorWhenPressed()
    {
        yield return new WaitForSeconds(0.1f);
        
    }
}
