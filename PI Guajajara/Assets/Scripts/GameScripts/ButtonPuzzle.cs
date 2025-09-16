using UnityEngine;

public class ButtonPuzzle : MonoBehaviour
{
    [SerializeField] string playerOrder = "";

    [SerializeField] static string correctOrder;

    [SerializeField] static int totalDigits;
    [SerializeField] GameObject unlockGamO;



     // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(playerOrder);
        if(totalDigits == 0)
        {
            if(playerOrder == correctOrder)
            {
                unlockGamO.SetActive(true);
            }
            else
            {
                totalDigits = 0;
                playerOrder = string.Empty;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerOrder += gameObject.name;
        totalDigits += 1;
    }
}

// video referencia https://www.youtube.com/watch?v=o7aC62Nsv-M
