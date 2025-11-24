using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HudDoPlayer : MonoBehaviour
{
    [Header("Ícones de Ammo")]
    public List<Image> ammoImages;

    [Header("Ícones de Vida")]
    public List<Image> lifeImages; 

    // Atualiza munição
    public void UpdateAmmo(int current, int max)
    {
        for (int i = 0; i < ammoImages.Count; i++)
        {
            ammoImages[i].enabled = i < current;
        }
    }

    // Atualiza vida do player
    public void UpdateLife(int current, int max)
    {
        for (int i = 0; i < lifeImages.Count; i++)
        {
            lifeImages[i].enabled = i < current;
        }
    }
}