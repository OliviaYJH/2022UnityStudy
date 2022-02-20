using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalsExercises : MonoBehaviour
{
    public float number1;
    public float number2;

    [Range(0, 100)]
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        if(number1 > number2){

        }else if(number2 > number1){

        }else{

        }

        if(score > 90){

        }else if(score > 80){

        }else{

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
