using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemData
{
    public string id;
    public string name;
}

[Serializable]
public class ItemDataArray
{
    public List<ItemData> itemList;
}
