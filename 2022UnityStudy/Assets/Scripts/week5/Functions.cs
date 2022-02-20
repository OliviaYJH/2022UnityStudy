using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    int health = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        WelcomePlayer("Sam");
        
        int functionResult = Add(5,10);
        print(functionResult);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            TakeDamage();
        }
    }

    void WelcomePlayer(string playerName){
        print("Welcome " + playerName);
        print("Good luck!");
    }

    int Add(int num1, int num2){
        int result = num1 + num2;
        return result;
    }

    void TakeDamage(){
        health -= 1;
        print("You took damage! You are now down to " + health);
    }

}
