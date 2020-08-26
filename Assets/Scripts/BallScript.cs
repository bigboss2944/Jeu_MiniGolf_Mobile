using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    public GameObject endMenu;
    public int niveauActuel;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag== "DropZoneTag")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (other.gameObject.tag == "EndZoneTag")
        {
            endMenu.SetActive(true);

            niveauActuel = SceneManager.GetActiveScene().buildIndex;

            PlayerPrefs.SetInt("DernierNiveau", niveauActuel);
        }
    }
}
