using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class QuestSystem : MonoBehaviour
{
    public Transform sphere; // References for objects
    public Transform cylinder; 
    public Transform cube; 

    public float questTriggerDistance = 2f; // quest tetikleyecek mesafe
    public float cubeTouchDistance = 1f; // k�be dokunulacak mesafe

    private bool questActivated = false;

    void Update()
    {
        // k�re silindire yak�n m� kontrol�. if so activate quest.
        if (Vector3.Distance(sphere.position, cylinder.position) < questTriggerDistance && !questActivated)
        {
            ActivateQuest();
        }

        // k�re k�be geldi mi kontrol�.if so quest completed
        if (Vector3.Distance(sphere.position, cube.position) < cubeTouchDistance && questActivated)
        {
            CompleteQuest();
        }
    }

    void ActivateQuest()
    {
        Debug.Log("QUEST: TOUCH CUBE");
        questActivated = true;
    }

    void CompleteQuest()
    {
        Debug.Log("YAY! MISSION SUCCESSFUL");
        
    }
}

