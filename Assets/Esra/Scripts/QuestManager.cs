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
        kiyafetCalmaQuest = new KiyafetCalmaQuest("K�yafet Calma G�revi", "D�� surlar� ge�mek i�in k�yafet �alma g�revi");
        bitkiToplamaQuest = new BitkiToplamaQuest("Bitki Toplama G�revi", "D�� surlar� ge�mek i�in bitki toplama g�revi");
        aileUyesiKurtarmaQuest = new AileUyesiKurtarmaQuest("Aile �yesi Kurtarma G�revi", "D�� surlar� ge�mek i�in aile �yesi kurtarma g�revi");
    }

    public void CompleteKiyafetCalmaQuest()
    {
        kiyafetCalmaQuest.CalmaDeneyimi();

        if (kiyafetCalmaQuest.isCompleted)
        {
            Debug.Log("K�yafet �alma g�revi tamamland�. Bir sonraki g�reve ge�iliyor.");
        }
        else
        {
            Debug.Log("Yakaland�n�z. K�yafet �alma g�revi tamamlanamad�.");
        }
    }

    public void CompleteBitkiToplamaQuest()
    {
        bitkiToplamaQuest.BitkiToplamaDeneyimi();

        if (bitkiToplamaQuest.isCompleted)
        {
            Debug.Log("Bitki toplama g�revi tamamland�. Bir sonraki g�reve ge�iliyor.");
        }
        else
        {
            Debug.Log("Bitki toplama g�revi tamamlanamad�.");
        }
    }

    public void CompleteAileUyesiKurtarmaQuest(bool aileUyesiBulundu)
    {
        aileUyesiKurtarmaQuest.KurtarmaDeneyimi(aileUyesiBulundu);

        if (aileUyesiKurtarmaQuest.isCompleted)
        {
            Debug.Log("Aile �yesi kurtarma g�revi tamamland�. Bir sonraki g�reve ge�iliyor.");
        }
        else
        {
            Debug.Log("Aile �yesi kurtarma g�revi tamamlanamad�.");
        }
    }
}


