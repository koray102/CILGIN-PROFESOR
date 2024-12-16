using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitkiToplamaQuest
{
    public string questName;
    public string questDescription;
    public bool isCompleted;

    public BitkiToplamaQuest(string name, string description)
    {
        questName = name;
        questDescription = description;
        isCompleted = false;
    }

    public void BitkiToplamaDeneyimi()
    {
        // Özel bitkileri toplama iþlemi burada gerçekleþir
        // isCompleted, bitki toplama iþleminin baþarýlý olup olmadýðýna baðlý olarak ayarlanýr
        isCompleted = true; // Gerçek implementasyona göre güncellencek
    }
}

