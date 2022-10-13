using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guessthenum : MonoBehaviour
{
    int maxnum = 1000;
    int minnum = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();

    }

    void StartGame()
    {
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick an number ");
        Debug.Log("The highest number should be less than " + maxnum);
        Debug.Log("The lowest number should be not less than 1" + minnum);
        Debug.Log("Is it lower or higher than 500 ?");
        Debug.Log("Push Up = Higher , Push Down = Lower , Push Enter = Correct");
        maxnum = maxnum + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            minnum = guess;
            NextGuess();

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            maxnum = guess;
            NextGuess();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return  Key was pressed : PLAY AGAIN ??.");
        }
    }

    void NextGuess()
    {
        guess = (maxnum + minnum) / 2;
        
        Debug.Log("The number is " + guess );
        Debug.Log(" Is this the number You Guessed? Then Press RETURN  Not ??. OK  your num highrt or lower than " + guess);
    }
}