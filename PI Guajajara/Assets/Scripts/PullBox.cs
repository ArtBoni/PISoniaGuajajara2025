using Unity.VisualScripting;
using UnityEngine;

public class PullBox : MonoBehaviour
{
    [SerializeField] Transform box;
    [SerializeField] int distance;
    bool isNearBox = false;
    private void Start()
    {
        isNearBox = false;
    }

    private void Update()
    {
        
    }
}
