using System.Collections.Generic;
using UnityEngine;

public class SequencePuzzle : MonoBehaviour
{
    [Header("Correct Order")]
    [SerializeField] private List<int> correctOrder = new List<int>();

    private List<int> playerOrder = new List<int>();

    [Header("Object To Activate When Solved")]
    [SerializeField] private GameObject objectToActivate;

    public void PressButton(int id)
    {
        playerOrder.Add(id);

        int index = playerOrder.Count - 1;

        // Wrong input
        if (playerOrder[index] != correctOrder[index])
        {
            Debug.Log("Wrong sequence! Resetting...");
            playerOrder.Clear();
        }

        // Completed sequence
        if (playerOrder.Count == correctOrder.Count)
        {
            Debug.Log("Puzzle Solved!");
            SolvePuzzle();
        }
    }

   

    private void SolvePuzzle()
    {
        if (objectToActivate != null)
            objectToActivate.SetActive(true);
    }
}
