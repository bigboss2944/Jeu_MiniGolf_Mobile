using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    
    public GameObject mainMenu;

    public void NewGame()
    {
        mainMenu.SetActive(false);
        PlayerPrefs.SetInt("DernierNiveau", 0);
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        string path = Application.persistentDataPath + "/player.fun";
        

        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            int data = (int)formatter.Deserialize(stream);
            stream.Close();
            SceneManager.LoadScene(data);

        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            
        }   
    }
}
