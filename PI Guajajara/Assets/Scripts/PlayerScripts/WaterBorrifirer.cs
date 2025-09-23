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

    private Camera mainCam;

    private void Start()
    {
        mainCam = Camera.main; 
    }

    private void Update()
    {
        AimAtMouse();
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void AimAtMouse()
    {
        Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - transform.position;   
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(waterPrefab, waterSpawnPoint.position, waterSpawnPoint.rotation);
        WaterProjetil proj = bullet.GetComponent<WaterProjetil>();
        if (proj != null)
            proj.SetDamage(damage);
        waterSound?.Play();
        OnWaterEvent?.Invoke(waterSound);
    }
}