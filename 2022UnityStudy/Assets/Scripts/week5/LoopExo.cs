using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopExo : MonoBehaviour
{
    int i = -5;

    // Start is called before the first frame update
    void Start()
    {
        for(int j = -5; j <= 5; j+= 1)   {
            print(j);
        }

        while(i <= 50){
            print(i);
            i += 2;
        }
        // same
        for(int l = 10; l <= 50; l += 2){
            print(l);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
