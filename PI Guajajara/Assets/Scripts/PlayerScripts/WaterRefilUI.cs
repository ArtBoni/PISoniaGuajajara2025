using TMPro;
using UnityEngine;

public class WaterRefilUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI waterTxt;
    [SerializeField] float currentWater;

    float maxWater = 15;
    private void Start()
    {
        currentWater = maxWater;
    }

    private void Update()
    {
        
    }
}
