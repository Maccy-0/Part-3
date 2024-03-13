using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterControl : MonoBehaviour
{
    public TMP_Text Class;
    
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
            
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        
    }

    private void Update()
    {
       Class.text = SelectedVillager.ToString();
    }
}
