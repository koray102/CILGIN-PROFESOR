using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AileUyesiKurtarmaQuest
{
    public string questName;
    public string questDescription;
    public bool isCompleted;

    public AileUyesiKurtarmaQuest(string name, string description)
    {
        questName = name;
        questDescription = description;
        isCompleted = false;
    }

    public void KurtarmaDeneyimi(bool aileUyesiBulundu)
    {
        // Aile üyesini kurtarma iþlemi burada gerçekleþir
        // isCompleted, kurtarma iþleminin baþarýlý olup olmadýðýna baðlý olarak ayarlanýr
        isCompleted = aileUyesiBulundu; // Gerçek implementasyona göre güncellencek
    }
}

