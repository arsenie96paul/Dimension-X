using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField]
    Text currentText;

    [SerializeField]
    Text highScore;

    private void Start()
    {
        currentText.text = "CurrentScore:"+PlayerPrefs.GetInt("CurrentScore").ToString();
        if ( PlayerPrefs.GetInt("CurrentScore") > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("CurrentScore"));
        }
        highScore.text = "HighScore:"+PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Options()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    
}
