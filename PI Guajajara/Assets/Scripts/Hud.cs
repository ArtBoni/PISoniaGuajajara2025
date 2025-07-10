using System;
using System.Collections.Generic;
using UnityEngine;



public class Hud : MonoBehaviour
{
    [SerializeField] List<GameObject> itemsSlot;
    [SerializeField] int selectedIndex;
    

    
    void Start()
    {
        SelectItem(selectedIndex);
    }


    private void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll > 0f) 
        {
            selectedIndex++;
            if(selectedIndex >= itemsSlot.Count)
                selectedIndex = 0;
            SelectItem(selectedIndex);          
        }
        else 
        {
            selectedIndex--;
            if(selectedIndex < 0)
                selectedIndex = itemsSlot.Count - 1;
            SelectItem(selectedIndex);
        }

        

    }

    public void SelectItem(int index)
    {
        for (int i = 0; i < itemsSlot.Count; i++) 
        {
            itemsSlot[i].SetActive(i == index);
        }
    }

   public void CollectItem()
   {

   }
}
