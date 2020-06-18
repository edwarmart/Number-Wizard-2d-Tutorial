﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()    
    {
        int max = 1000;
        int min = 1;


        Debug.Log("Welcome to number wizard,  yo."); // Debug.log is Technically better
        Debug.Log("Pick A Number!");
        Debug.Log("The Highest Number is: " + max);
        Debug.Log("The Lowest Number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500.");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
        }
        {
            //Detect when the down arrow key is pressed down
            if (Input.GetKeyDown(KeyCode.DownArrow))
                Debug.Log("Down Arrow key was pressed.");
        }
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("Return key was pressed.");
            }
        }
    }
}
