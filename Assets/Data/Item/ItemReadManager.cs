using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ItemReadManager : MonoBehaviour
{
    ItemDataArray itemDataArray = new();
    public Dictionary<string, ItemData> itemDict = new Dictionary<string, ItemData>();

    void Awake()
    {
        LoadItemJson();
    }

    void LoadItemJson()
    {
        //  Œã‚Å‚â‚é
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/itemdata.json");
        itemDataArray = JsonUtility.FromJson<ItemDataArray>(json);

        foreach (var data in itemDataArray.itemList)
        {
            itemDict[data.id] = data;
        }
        
    }
}
