using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleMouvement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move;
        float gravity=-9.8f;
        float x;
        float y;

        if (Input.anyKey)
        {
            x = Input.GetAxis("Horizontal");
            y = gravity * Time.deltaTime;

            move = (transform.forward * x/16) + transform.up * y;
            controller.Move(move * speed * Time.deltaTime);
        }
        else
        {
            y = gravity*Time.deltaTime;
            move = transform.up * y;
        }


        controller.Move(move * speed * Time.deltaTime);


    }
}
