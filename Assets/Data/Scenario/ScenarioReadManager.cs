using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class ScenarioReadManager : MonoBehaviour
{
    ScenarioDataArray scenarioDataArray = new();
    public Dictionary<string, ScenarioData> scenarioDict = new Dictionary<string, ScenarioData>();

    void Awake()
    {
        LoadScenarioJson();
    }

    void LoadScenarioJson()
    {
        /*
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/scenario.json");
        scenarioDataArray = JsonUtility.FromJson<ScenarioDataArray>(json);

        foreach (var data in scenarioDataArray.scenarioList)
        {
            scenarioDict[data.id] = data;
        }
        //scenarioDict["a"].data[2].message
        //ScenarioData a = scenarioDict["a"];
        //a.data[0].message
        */
    }
}
