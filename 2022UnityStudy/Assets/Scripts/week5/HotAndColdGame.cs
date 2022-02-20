using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotAndColdGame : MonoBehaviour
{
    int randomNumber;
    [Range(0, 100)]
    public int guess;

    int numberOfAttempts;

    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0,101);
        print("Welcome to the Hot & Cold number guessing game ~~~");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            numberOfAttempts += 1;
            if(guess == randomNumber){
                print("You Won! It took you " + numberOfAttempts.ToString() + "attemps");
            }else if(Mathf.Abs(randomNumber - guess) <= 10){
                print("Boiling.");
            }
        }
    }
}
