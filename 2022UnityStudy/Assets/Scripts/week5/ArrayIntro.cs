using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayIntro : MonoBehaviour
{
    string[] playerNames = new string[] { "Bob", "Liam", "Noa", "Sam", "Leo"};

    // Start is called before the first frame update
    void Start()
    {
        print(playerNames[0]); 
        print(playerNames[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
