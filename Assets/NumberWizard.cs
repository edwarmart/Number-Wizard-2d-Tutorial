using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()    
    {
        StartGame();
    }

    // Update is called once per frame
    
    void StartGame()
    {
        Debug.Log("Hello there, and Greetings! Welcome to the Number Wizard!"); // Debug.log is Technically better
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
                Debug.Log("Is it higher or lower than..." + guess + "?");
                max = guess;
                guess = (max + min) / 2; 
                Debug.Log(guess);
        }
  
           else  if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log(guess + " was your number, correct?");
            }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher than lower than..." + guess + "?");
    }
}
