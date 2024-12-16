using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KiyafetCalmaQuest
{
    public string questName;
    public string questDescription;
    public bool isCompleted;
    public YakalanmaDurumu yakalanmaDurumu;

    public KiyafetCalmaQuest(string name, string description)
    {
        questName = name;
        questDescription = description;
        isCompleted = false;
        yakalanmaDurumu = new YakalanmaDurumu();
    }

    public void CalmaDeneyimi()
    {
        bool yakalanmaDurumu = CalmaIslemi();

        if (yakalanmaDurumu)
        {
            this.yakalanmaDurumu.SicileIsle();
        }

        isCompleted = !yakalanmaDurumu;
    }

    private bool CalmaIslemi()
    {
        // Kýyafet çalma iþlemi burada gerçekleþir
        // Yakalanma durumu nasýl belirlenicek??Burada rastgele belirlendi.
        return UnityEngine.Random.Range(0, 2) == 0;

    }
}

public class YakalanmaDurumu
{
    public bool isYakalandi;

    public void SicileIsle()
    {
        isYakalandi = true;
        Debug.Log("Yakalanma durumu sicile iþlendi.");
    }
}

