using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuShow : MonoBehaviour
{
    public Text starsTxt;
    public Text propinaTxt;
    public Text levelTxt;

    // Update is called once per frame
    void Update()
    {
        starsTxt.text = GlobalVariableManager.starsInventory.ToString();
        propinaTxt.text = GlobalVariableManager.propinaInventory.ToString();
        levelTxt.text = GlobalVariableManager.levelNumber.ToString();
    }
}
