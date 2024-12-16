using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DealerInfo", menuName = "ÇILGIN PROFESÖR/DealerInfo", order = 0)]

public class DealerInfo : ScriptableObject 
{
    public string dealerName;
    public string dealerJob;
    public Item[] dealerItems;
}
