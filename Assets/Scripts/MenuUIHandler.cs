using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TextMeshProUGUI highScoreText;



    private void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        string highScorePlayer = PlayerPrefs.GetString("HighScorePlayer", "None");

        highScoreText.text = $"High Score: {highScorePlayer} - {highScore}";
    }
    public void StartGame()
    {

        string playerName = nameInputField.text; //get name from InputField

        if (!string.IsNullOrEmpty(playerName))
        {
            PlayerPrefs.SetString("PlayerName", playerName);//save name
            PlayerPrefs.Save();//Ensure data is stored

        }

            SceneManager.LoadScene("main"); //when the start button is pressed main scene will load

    }

    public void QuitGame()
    {
        
    }
}
