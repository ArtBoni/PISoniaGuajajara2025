using TMPro;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class AudioEvent : UnityEvent<AudioSource> { }

public class WaterBorrifirer : MonoBehaviour
{
    public static WaterBorrifirer instance;
    [Header("Water Settings")]
    [SerializeField] private GameObject waterPrefab;
    [SerializeField] private Transform waterSpawnPoint;
    [SerializeField] private float damage = 5f;
    [SerializeField] TextMeshProUGUI waterTxt;
    [SerializeField] public float currentWater;

    

    [Header("Audio")]
    [SerializeField] private AudioSource waterSound;
    [SerializeField] private AudioEvent OnWaterEvent;


    [Header("UnityEvents")]
    

    private Camera mainCam;
    float maxWater = 5;
    bool canShoot = true;

    private void Start()
    {
        instance = this;
        mainCam = Camera.main;
        currentWater = maxWater;
        canShoot = true;

    }

    private void Update()
    {
        waterTxt.text = currentWater + "/" + maxWater;
        AimAtMouse();
        if(canShoot)
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            currentWater--;
            
        }

        
        
        if (currentWater <= 0)
        {
            canShoot = false;
            if (!canShoot)
                return;
                
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
    public void GetAmmo()
    {
        currentWater = maxWater;

    }
}