using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Cysharp.Threading.Tasks;

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI uiText;


    [SerializeField] GManager gmanager;
    [SerializeField] ScenarioReadManager scenario;
    
    public async UniTask Dialogue(string scenario)
    {
            uiText.text = "";

            foreach (var word in scenario)
            {
                uiText.text += word;
                await UniTask.WaitForSeconds(0.1f);
            }
    }
   
}
