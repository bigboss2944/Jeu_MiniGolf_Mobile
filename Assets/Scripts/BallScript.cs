using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    public GameObject endMenu;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag== "DropZoneTag")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (other.gameObject.tag == "EndZoneTag")
        {
            endMenu.SetActive(true);
        }
    }
}
