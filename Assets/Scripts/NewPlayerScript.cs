using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewPlayerScript : MonoBehaviour
{
    public GameObject firstName;
   
    // Start is called before the first frame update
    public void GetFirstName()
    {
        string firstNameString;
        firstNameString = firstName.GetComponent<Text>().text;
        PlayerPrefs.SetInt("DernierNiveau", 0);
        PlayerPrefs.SetString("Nom",firstNameString);
        SceneManager.LoadScene(1);
    }
}
