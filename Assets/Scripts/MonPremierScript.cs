using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonPremierScript : MonoBehaviour
{
    int money = 0;
    // Start is called before the first frame update
    void Start()
    {
        print(money);
        money += 5;
        print(money);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
