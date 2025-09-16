using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class AudioEvent : UnityEvent<AudioSource> { }

public class WaterBorrifirer : MonoBehaviour
{
    [Header("Water Settings")]
    [SerializeField] private GameObject waterPrefab;
    [SerializeField] private Transform waterSpawnPoint;
    [SerializeField] private float damage = 5f;

    [Header("Audio")]
    [SerializeField] private AudioSource waterSound;
    [SerializeField] private AudioEvent OnWaterEvent;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(waterPrefab, waterSpawnPoint.position, waterSpawnPoint.rotation);
        WaterProjetil proj = bullet.GetComponent<WaterProjetil>();

        if (proj != null)
            proj.SetDamage(damage);

        OnWaterEvent?.Invoke(waterSound);
    }
}