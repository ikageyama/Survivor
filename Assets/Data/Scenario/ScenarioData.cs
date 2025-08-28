using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ScenarioData
{
    public string scene;
    public List<string> messageList;
}
[Serializable]
public class ScenarioDataArray
{
    public List<ScenarioData> scenarioList;
}
