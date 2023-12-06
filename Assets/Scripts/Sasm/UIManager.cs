using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public ScenedataSO ScenedataSO;

    public TMP_Text currentPopText;
    void Update()
    {
        currentPopText.text = "Current Population: " + ScenedataSO.currentPop;
    }
}
