using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class ScenarioReadManager : MonoBehaviour
{
    ScenarioDataArray scenarioDataArray = new();
    public Dictionary<string, List<string>> scenarioDict = new Dictionary<string, List<string>>();

    void Awake()
    {
        LoadScenarioJson();
    }

    void LoadScenarioJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/scenario.json");
        scenarioDataArray = JsonUtility.FromJson<ScenarioDataArray>(json);

        foreach (var data in scenarioDataArray.scenarioList)
        {
            scenarioDict[data.scene] = data.messageList;
        }
    }
}
