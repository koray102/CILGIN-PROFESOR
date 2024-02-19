using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuestManager : MonoBehaviour
{
    public KiyafetCalmaQuest kiyafetCalmaQuest;
    public BitkiToplamaQuest bitkiToplamaQuest;
    public AileUyesiKurtarmaQuest aileUyesiKurtarmaQuest;

    private void Start()
    {
        InitializeQuests();
    }

    private void InitializeQuests()
    {
        kiyafetCalmaQuest = new KiyafetCalmaQuest("Kýyafet Calma Görevi", "Dýþ surlarý geçmek için kýyafet çalma görevi");
        bitkiToplamaQuest = new BitkiToplamaQuest("Bitki Toplama Görevi", "Dýþ surlarý geçmek için bitki toplama görevi");
        aileUyesiKurtarmaQuest = new AileUyesiKurtarmaQuest("Aile Üyesi Kurtarma Görevi", "Dýþ surlarý geçmek için aile üyesi kurtarma görevi");
    }

    public void CompleteKiyafetCalmaQuest()
    {
        kiyafetCalmaQuest.CalmaDeneyimi();

        if (kiyafetCalmaQuest.isCompleted)
        {
            Debug.Log("Kýyafet çalma görevi tamamlandý. Bir sonraki göreve geçiliyor.");
        }
        else
        {
            Debug.Log("Yakalandýnýz. Kýyafet çalma görevi tamamlanamadý.");
        }
    }

    public void CompleteBitkiToplamaQuest()
    {
        bitkiToplamaQuest.BitkiToplamaDeneyimi();

        if (bitkiToplamaQuest.isCompleted)
        {
            Debug.Log("Bitki toplama görevi tamamlandý. Bir sonraki göreve geçiliyor.");
        }
        else
        {
            Debug.Log("Bitki toplama görevi tamamlanamadý.");
        }
    }

    public void CompleteAileUyesiKurtarmaQuest(bool aileUyesiBulundu)
    {
        aileUyesiKurtarmaQuest.KurtarmaDeneyimi(aileUyesiBulundu);

        if (aileUyesiKurtarmaQuest.isCompleted)
        {
            Debug.Log("Aile üyesi kurtarma görevi tamamlandý. Bir sonraki göreve geçiliyor.");
        }
        else
        {
            Debug.Log("Aile üyesi kurtarma görevi tamamlanamadý.");
        }
    }
}


