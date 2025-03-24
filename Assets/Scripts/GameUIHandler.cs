using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIHandler : MonoBehaviour
{

    public Text nameDisplayText;


    private void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        nameDisplayText.text = playerName;
    }

}
