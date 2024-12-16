using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class Dealer : MonoBehaviour
{
    [Header("Dealer Info")]
    public DealerInfo dealerInfo;
    private string dealerName;
    private string dealerJob;

    [Header("Items")]
    public Transform itemTemplate;
    public Transform shopItems;
    private int positionIndex = 0;
    private float itemTemplateHeight;

    void Start()
    {
        dealerName = dealerInfo.dealerName;
        dealerJob = dealerInfo.dealerJob;

        itemTemplateHeight = itemTemplate.Find("Background").GetComponent<RectTransform>().rect.height;

        foreach (var item in dealerInfo.dealerItems)
        {
            CreateItem(item, positionIndex, itemTemplateHeight);
            positionIndex++;
        }

        itemTemplate.gameObject.SetActive(false);
    }

    private void CreateItem(Item itemSO, int positionIndex, float itemHeight)
    {
        Transform itemTransform = Instantiate(itemTemplate, shopItems);
        RectTransform itemRectTransform = itemTransform.GetComponent<RectTransform>();
        
        itemRectTransform.anchoredPosition = new Vector2(0, -itemHeight * positionIndex - positionIndex * 10);

        itemTransform.Find("Item Name").GetComponent<TextMeshProUGUI>().SetText(itemSO.itemName);
        itemTransform.Find("Item Value").GetComponent<TextMeshProUGUI>().SetText(itemSO.itemValue.ToString());
    }
}
