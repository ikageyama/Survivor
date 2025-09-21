using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<int> previousValueList = new List<int>();

    [SerializeField] private List<TextMeshProUGUI> parameterText = new List<TextMeshProUGUI>();
    [SerializeField] private List<TextMeshProUGUI> itemNumText = new List<TextMeshProUGUI>();
    [SerializeField] private List<TextMeshProUGUI> itemNameText = new List<TextMeshProUGUI>();
    [SerializeField] private List<Button> itemButtonList = new List<Button>();
    [SerializeField] private List<Image> itemImageList = new List<Image>();



    [SerializeField] ItemReadManager itemReadManager;
    [SerializeField] ItemManager itemManager;
    [SerializeField] PlayerData playerData;
    [SerializeField] GManager gManager;
    
    enum ParameterName
    {
        life,
        water,
        food,
        injury,
        survival,
        escape,
        days
    }

    void Start()
    {
        playerData.Life = 100;
        playerData.Water = 100;
        playerData.Food = 100;
        playerData.Injury = 0;
        playerData.Survival = 0;
        playerData.Escape = 0;
        ItemUse();
    }

    void Update()
    {
        ParameterChange(playerData.Life, (int)ParameterName.life);
        ParameterChange(playerData.Water, (int)ParameterName.water);
        ParameterChange(playerData.Food, (int)ParameterName.food);
        ParameterChange(playerData.Injury, (int)ParameterName.injury);
        ParameterChange(playerData.Survival, (int)ParameterName.survival);
        ParameterChange(playerData.Escape, (int)ParameterName.escape);
        ParameterChange(gManager.days, (int)ParameterName.days);
        //Debug.Log(playerData.Water);
        ItemText();
        
    }

    void ParameterChange(int value,int index)
    {
        if(value != previousValueList[index])
        {
            previousValueList[index] = value;
            parameterText[index].text = value.ToString();
        }
    }

    void ItemText()
    {
        int index = 0;

        foreach (var item in itemManager.itemDict)
        {
            if (index < itemNameText.Count && index < itemNumText.Count)
            {
                itemNameText[index].text = item.Key;            // アイテム名
                itemNumText[index].text = item.Value.ToString(); // 所持数

                // ボタンと画像を表示
                if (index < itemButtonList.Count)
                {
                    itemButtonList[index].gameObject.SetActive(true);
                }
                if (index < itemImageList.Count)
                {
                    itemImageList[index].gameObject.SetActive(true);
                }
                index++;
            }
            else
            {
                Debug.LogWarning("UIテキスト配列が不足しています。アイテム数が多すぎる可能性があります。");
                break;
            }
        }

        // 余ったUI欄を空にする（前回の表示が残らないように）
        for (int i = index; i < itemNameText.Count; i++)
        {
            itemNameText[i].text = "";
            itemNumText[i].text = "";
        }
    }

    void ItemUse()
    {
       for(int i = 0; i < itemButtonList.Count; i++)
        {
            int index = i;
            itemButtonList[index].onClick.AddListener(() =>
            {
                if(itemNameText[index].text == "肉")
                {
                    Debug.Log("肉");
                }
                if (itemNameText[index].text == "水")
                {
                    Debug.Log("水");
                }
                if (itemNameText[index].text == "木")
                {
                    Debug.Log("木");
                }
            });
        }
    }
}
