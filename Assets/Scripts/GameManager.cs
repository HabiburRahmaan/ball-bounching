using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject WinText;
    public GameObject restartBTN;
    int Score = 0;
   

    
    void Update()
    {
        
    }
    public void Scoreup()
    {
        Score++;
        if (Score>=8)
        {

            win();
        }
    }

    void win()
    {
        WinText.SetActive(true);
        restartBTN.SetActive(true);
    }

public void Restart()
    {
        SceneManager.LoadScene("Game");

    }

    
}
