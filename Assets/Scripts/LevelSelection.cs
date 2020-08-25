using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    Button[] btns;

    public void LoadSelectedLevel(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Start()
    {
        int lastLevel = PlayerPrefs.GetInt("DernierNiveau");
        btns = GameObject.FindObjectsOfType<Button>();
        foreach (Button btn in btns)
        {
            int level = int.Parse(btn.transform.GetChild(0).gameObject.GetComponent<Text>().text);

            if (level <= lastLevel)
            {
                btn.interactable = true;
            }
        }

    }
}
