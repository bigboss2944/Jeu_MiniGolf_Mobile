using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public int nbShotsLeft = 5;
    public int power = 500;
    public GameObject balle;

    public void Shoot()
    {
        if (nbShotsLeft > 0)
        {
            nbShotsLeft--;
            balle.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward*power);
        }
    }
}
