using UnityEngine;

public class ElevatorDoors : MonoBehaviour
{
    Animator anima;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    public void PlayAnima()
    {
        anima.SetBool("interactedWith", true);
    }
}
