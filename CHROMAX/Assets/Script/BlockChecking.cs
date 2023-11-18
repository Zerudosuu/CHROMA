using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockChecking : MonoBehaviour
{
    public Script1 redBlockScripts; // Assign the Script1 component for the red block in the Inspector
    public Script1 blueBlockScripts; // Assign the Script1 component for the blue block in the Inspector
    public Script1 yellowBlockScripts; // Assign the Script1 component for the yellow block in the Inspector
    public Script1 greenBlockScripts; // Assign the Script1 component for the green block in the Inspector

    public bool isRedCollided = false;
    public bool isBlueCollided = false;
    public bool isYellowCollided = false;
    public bool isGreenCollided = false;

    public float rotationValueRed; 
    public float rotationValueBlue;  
    public float rotationValueYellow;  
    public float rotationValueGreen; 

    void Update()
    {
        isRedCollided = redBlockScripts.isCollidingWithOwnColor;
        isBlueCollided = blueBlockScripts.isCollidingWithOwnColor;
        isYellowCollided = yellowBlockScripts.isCollidingWithOwnColor;
        isGreenCollided = greenBlockScripts.isCollidingWithOwnColor;

        rotationValueRed = redBlockScripts.rotationZ; 
        rotationValueBlue = blueBlockScripts.rotationZ; 
        rotationValueYellow = yellowBlockScripts.rotationZ; 
        rotationValueGreen = greenBlockScripts.rotationZ; 


        if (isRedCollided)
        {
            Debug.Log("Red collision");
        }
        else if (isBlueCollided)
        {
            Debug.Log("Blue collision");
        }
        else if (isYellowCollided)
        {
            Debug.Log("Yellow collision");
        }
        else if (isGreenCollided)
        {
            Debug.Log("Green collision");
        }
    }
}
