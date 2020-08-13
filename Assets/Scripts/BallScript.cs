using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    public GameObject endMenu;
    public GameObject gameOverMenu;
    public GameObject balle;
    public AudioClip gameOver;
    public AudioClip clapSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag== "DropZoneTag")
        {
            balle.GetComponent<AudioSource>().PlayOneShot(gameOver);
            gameOverMenu.SetActive(true);
        }

        if (other.gameObject.tag == "EndZoneTag")
        {
            balle.GetComponent<AudioSource>().PlayOneShot(clapSound);
            endMenu.SetActive(true);
        }
    }
}
