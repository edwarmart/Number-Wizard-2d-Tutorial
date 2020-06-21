using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()    
    {
        StartGame();
    }

    // Update is called once per frame
    
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;


        Debug.Log("Hello there, and Greetings! Welcome to the Number Wizard!"); // Debug.Log is Technically better than Print. 
        Debug.Log("Pick A Number!");
        Debug.Log("The Highest Number is: " + max);
        Debug.Log("The Lowest Number is: " + min);
        Debug.Log("Tell me if this is your number, or if it's higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }
      
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        
            //Detect when the down arrow key is pressed down
            else if (Input.GetKeyDown(KeyCode.DownArrow))
        { 
                max = guess;
                NextGuess();
        }
  
           else  if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log(guess + " was your number, correct?");
                StartGame();
            }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher than lower than..." + guess + "?");
    }
}
