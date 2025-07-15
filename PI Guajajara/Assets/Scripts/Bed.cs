using UnityEngine;
using UnityEngine.Events;

interface ISleepable
{
    public void Sleep();
}
enum VillageVersion
{
    FINE, BURNING
}

public class Bed : MonoBehaviour
{
    [SerializeField] VillageVersion villageVersion = VillageVersion.FINE;
    public UnityEvent onBurning;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ISleepable sleepObj))
        {
            Burn();
        }
    }
    private void Start()
    {
        onBurning.AddListener(Burn);
    }
    public void Burn()
    {
        villageVersion = VillageVersion.BURNING;
    }
}
