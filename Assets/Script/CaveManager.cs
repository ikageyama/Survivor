using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaveManager : MonoBehaviour
{
    private int barrelInWater = 0;
    [SerializeField] private List<Button> buttonList = new List<Button>();

    [SerializeField] ItemManager itemManager;
    [SerializeField] PlayerData playerData;

    enum ButtonName
    {
        watter
    }

    void Start()
    {
        buttonList[(int)ButtonName.watter].onClick.AddListener(() => {
            if(barrelInWater >= 10)
            {
                barrelInWater -= 10;
                playerData.Water += 10;
                if (playerData.Water > 100)
                {
                    playerData.Water = 100;
                }
            }

        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
