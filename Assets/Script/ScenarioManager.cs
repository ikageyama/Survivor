using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cysharp.Threading.Tasks;

public class ScenarioManager : MonoBehaviour
{
    [SerializeField] List<string> sceneName = new List<string>();

    [SerializeField] private Button nextButton;
    [SerializeField] ScenarioReadManager scenario;
    [SerializeField] TextManager textManager;
    [SerializeField] GManager gManager;

    public async void Start()
    {
        nextButton.onClick.AddListener(async () =>
        {
            nextButton.interactable = false;
            if (gManager.messageindex >= scenario.scenarioDict[sceneName[gManager.sceneindex]].Count)
            {
                //éüÇÃÉVÅ[ÉìÇ÷
                gManager.sceneindex++;
                gManager.messageindex = 0;
                await textManager.Dialogue(scenario.scenarioDict[sceneName[gManager.sceneindex]][gManager.messageindex]);
                gManager.messageindex++;
            }
            else
            {
                await textManager.Dialogue(scenario.scenarioDict[sceneName[gManager.sceneindex]][gManager.messageindex]);
                gManager.messageindex++;
            }
            Debug.Log(gManager.messageindex);
            nextButton.interactable = true;
        });
    }

}
