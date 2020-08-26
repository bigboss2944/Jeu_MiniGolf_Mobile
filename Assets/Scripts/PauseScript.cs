using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject menuPause;

    public void ActivatePause()
    {
        menuPause.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void DesactivatePause()
    {
        menuPause.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void Reload()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        menuPause.SetActive(false);
    }

    public void BackToSelectionLevel()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
        menuPause.SetActive(false);
    }

    public void NextLevel()
    {
        Time.timeScale = 1.0f;
        int level = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(level);
        SavePlayer(level);
        menuPause.SetActive(false);
    }

    public static void SavePlayer(int level)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";

        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, level);

        stream.Close();
    }
}
