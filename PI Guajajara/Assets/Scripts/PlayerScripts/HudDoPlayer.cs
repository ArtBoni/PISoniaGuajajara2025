using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HudDoPlayer : MonoBehaviour
{
    public List<Image> ammoImages;

    public void UpdateAmmo(int current, int max)
    {
        for (int i = 0; i < ammoImages.Count; i++)
        {
            ammoImages[i].enabled = i < current;
        }
    }
}