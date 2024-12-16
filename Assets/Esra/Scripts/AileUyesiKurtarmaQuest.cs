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
        // Aile �yesini kurtarma i�lemi burada ger�ekle�ir
        // isCompleted, kurtarma i�leminin ba�ar�l� olup olmad���na ba�l� olarak ayarlan�r
        isCompleted = aileUyesiBulundu; // Ger�ek implementasyona g�re g�ncellencek
    }
}

