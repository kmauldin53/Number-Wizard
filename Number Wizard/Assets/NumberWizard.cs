using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;


    // Use this for initialization
    void Start()
    {
        GameStart();
        
    }

    void GameStart() 
    {
        min = 0;
        guess = 500;

        Debug.Log("Hello, My name is Gandriel. \n I am the Number Wizard!");
        Debug.Log("Now I can guess what number you are thinking of right now. First guess a number between 1 and 1000");
        Debug.Log("Is your number " + guess);
        Debug.Log("press up on the arrow key if it is above " + guess);
        Debug.Log("press down on the arrow key if it is below " + guess);
        Debug.Log("press Enter if my guess is Correct");
        max = max + 1;


    }

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
		else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I'm a Genius!");
            GameStart();
        }
	}

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }

}
