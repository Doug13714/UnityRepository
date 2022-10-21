using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{    
    private bool pressedF = false;
    private int count = 0;
 
    void Start()
    {
        this.GetComponent<Light>().enabled = false;
    }

    void Update()
    {        
        if(Input.GetKey(KeyCode.F)) {
            if(pressedF == false) {
                pressedF = true;            
                if(this.GetComponent<Light>().enabled == false)
                    this.GetComponent<Light>().enabled = true;
                else
                    this.GetComponent<Light>().enabled = false;
            }
        }
        count++;

        if(count >= 30) {
            pressedF = false;
            count = 0;
        }
    }
}
