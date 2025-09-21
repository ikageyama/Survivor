using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    //アイテム名と所持数
    public Dictionary<string, int> itemDict = new Dictionary<string, int>();

    [SerializeField] ItemReadManager itemReadManager;
    [SerializeField] GManager gManager;

    void Start()
    {
        ItemGet(itemReadManager.itemDict["meat"].name);
        ItemGet(itemReadManager.itemDict["water"].name);
        ItemGet(itemReadManager.itemDict["water"].name);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //アイテム取得、整理
    public void ItemGet(string itemName)
    {
        if (itemDict.ContainsKey(itemName))
        {
            // すでに所持しているアイテムなら数量を増やす
            itemDict[itemName]++;
            Debug.Log($"Item '{itemName}' count increased to {itemDict[itemName]}");
        }
        else
        {
            // 新しいアイテムなら登録して1個所持
            itemDict.Add(itemName, 1);
            Debug.Log($"New item '{itemName}' added with count 1");
        }


    }


}
