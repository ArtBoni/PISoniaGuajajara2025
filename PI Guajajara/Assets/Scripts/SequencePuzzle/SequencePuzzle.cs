using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SequencePuzzle : MonoBehaviour
{
    [Header("Correct Order")]
    [SerializeField] private List<int> correctOrder = new List<int>();

    private List<int> playerOrder = new List<int>();

    [Header("Object To Activate When Solved")]
    [SerializeField] private UnityEvent OnObjectToActivate;


    [SerializeField] UnityEvent OnWrongPuzzle, OnCorrectPuzzle;
    public void PressButton(int id)
    {
        playerOrder.Add(id);

        int index = playerOrder.Count - 1;

        // Wrong input
        if (playerOrder[index] != correctOrder[index])
        {
            OnWrongPuzzle.Invoke();
            Debug.Log("Wrong sequence! Resetting...");
            playerOrder.Clear();
        }

        // Completed sequence
        if (playerOrder.Count == correctOrder.Count)
        {
            OnCorrectPuzzle.Invoke();
            Debug.Log("Puzzle Solved!");
            SolvePuzzle();
        }
    }

   

    private void SolvePuzzle()
    {
        OnObjectToActivate.Invoke();
    }
}
