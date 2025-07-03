using System.Collections;
using UnityEngine;

public class WaterBorrifirer : MonoBehaviour, IStun
{
    [SerializeField] GameObject water;
    [SerializeField] Transform waterPos;
    IStun target;


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            target?.StunEnemy(5f);
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(water, waterPos.position, waterPos.rotation);
    }

    

    public void StunEnemy(float timer)
    {
        
    }
}
