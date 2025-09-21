using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ScenarioData
{
    public string id;
    public string scene;
    public List<MessageData> data;
}

[Serializable]
public class ScenarioDataArray
{
    public List<ScenarioData> scenarioList;
}

[Serializable]
public class MessageData
{
    public string message;
    public string next;
    public List<List<string>> options;
    public List<Itemdata> get;
    public List<Itemdata> random;
}

[Serializable]
public class Itemdata
{
    public string id;
    public int num;
    public int rate;
}
