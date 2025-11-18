using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudDoPlayer : MonoBehaviour
{
    public List<Image> ammoBlocks; 
    public int maxAmmo = 5;

    public void UpdateAmmo(int currentAmmo)
    {
        currentAmmo = Mathf.Clamp(currentAmmo, 0, maxAmmo);

        for (int i = 0; i < ammoBlocks.Count; i++)
        {
            ammoBlocks[i].gameObject.SetActive(i < currentAmmo);
        }
    }
}
