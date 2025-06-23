using System.Collections;
using UnityEngine;

public class WaterBorrifirer : MonoBehaviour
{
    [SerializeField] GameObject water;
    [SerializeField] Transform waterPos;


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(water, waterPos.position, waterPos.rotation);
    }

}
