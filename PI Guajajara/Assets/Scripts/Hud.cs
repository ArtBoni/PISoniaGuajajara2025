using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item
{
    GameObject itens;
    int itensQtd;

    public void Inventory(GameObject itens, int itensQtd)
    {
        this.itens = itens;
        this.itensQtd = itensQtd;
       
    }
}


public class Hud : MonoBehaviour
{
    [SerializeField] List<Item> objects = new List<Item>();
    [SerializeField] int itensLimit;
    


    void Start()
    {
        
    }

    
}
