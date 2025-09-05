using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class AudioEvent: UnityEvent<AudioSource> { }



public class WaterBorrifirer : MonoBehaviour, IDamegabled
{
    [SerializeField] GameObject water;
    [SerializeField] Transform waterPos;
    [SerializeField] private AudioEvent OnWaterEvent;
    [SerializeField] private AudioSource waterSound;
    
    IDamegabled target;


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            target?.Hit(5f); 
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(water, waterPos.position, waterPos.rotation);
        print($"Borrifire {waterSound}");
        OnWaterEvent.Invoke(waterSound);

    }
    public void Hit(float timer)
    {
        
    }
}
