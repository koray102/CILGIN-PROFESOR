using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class QuestSystem : MonoBehaviour
{
    public Transform sphere; // References for objects
    public Transform cylinder; 
    public Transform cube; 

    public float questTriggerDistance = 2f; // quest tetikleyecek mesafe
    public float cubeTouchDistance = 1f; // kübe dokunulacak mesafe

    private bool questActivated = false;

    void Update()
    {
        // küre silindire yakýn mý kontrolü. if so activate quest.
        if (Vector3.Distance(sphere.position, cylinder.position) < questTriggerDistance && !questActivated)
        {
            ActivateQuest();
        }

        // küre kübe geldi mi kontrolü.if so quest completed
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

