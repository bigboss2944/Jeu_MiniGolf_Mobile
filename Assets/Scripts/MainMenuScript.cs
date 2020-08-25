using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public GameObject newPlayer;
    public GameObject mainMenu;

    public void NewGame()
    {
        newPlayer.SetActive(true);
        mainMenu.SetActive(false);
        //PlayerPrefs.SetInt("DernierNiveau", 0);
        //sceneManager.LoadScene(0);
    }
}
