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
        // �zel bitkileri toplama i�lemi burada ger�ekle�ir
        // isCompleted, bitki toplama i�leminin ba�ar�l� olup olmad���na ba�l� olarak ayarlan�r
        isCompleted = true; // Ger�ek implementasyona g�re g�ncellencek
    }
}

