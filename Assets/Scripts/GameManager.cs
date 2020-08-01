using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameObject[] pause;

    public GameObject completeLevelUI;



    private void Start()
    {
        pause = GameObject.FindGameObjectsWithTag("pause");
        foreach (GameObject pauobj in pause)
        {
            pauobj.SetActive(false);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        foreach (GameObject pauobj in pause)
        {
            pauobj.SetActive(true);
        }

    }

    public void UnPause()
    {
        Time.timeScale = 1;
        foreach (GameObject pauobj in pause)
        {
            pauobj.SetActive(false);
        }

    }


    public void Restart()
    { 
        SceneManager.LoadScene("Game");
    
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Splash");
    }

    public void CompleteLevel()
    {
        Time.timeScale = 0;
        completeLevelUI.SetActive(true);
    }

}
