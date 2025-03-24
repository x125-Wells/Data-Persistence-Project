using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        string playerName = nameInputField.text; //get name from InputField
        PlayerPrefs.SetString("PlayerName", playerName);//save name
        PlayerPrefs.Save();//Ensure data is stored

        SceneManager.LoadScene("main"); //when the start button is pressed main scene will load
    }

    public void QuitGame()
    {
        
    }
}
