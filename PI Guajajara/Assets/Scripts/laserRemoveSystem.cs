using Unity.VisualScripting;
using UnityEngine;

public class laserRemoveSystem : MonoBehaviour
{
    private bool rActive = false;
    private bool lActive = false;
    [SerializeField] GameObject laser;
    public void ActivateL()
    {
        lActive = true;
        if (rActive == true) 
        {
            laser.SetActive(false);
        }
    }
    public void ActivateR()
    {
        rActive = true;
        if (lActive == true)
        {
            laser.SetActive(false);
        }
    }
}
