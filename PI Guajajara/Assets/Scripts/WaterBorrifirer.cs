using System.Collections;
using UnityEngine;

public class WaterBorrifirer : MonoBehaviour, IHit
{
    [SerializeField] GameObject water;
    [SerializeField] Transform waterPos;
    IHit target;


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
    }
    public void Hit(float timer)
    {
        
    }
}
