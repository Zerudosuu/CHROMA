using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScript : MonoBehaviour
{
    // Start is called before the first frame update
     public BlockChecking blockcheck; 
    public bool isYellowAffectedByRotation = false; 
    public bool isBlueAffectedByRotation = false; 
    public bool isRedAffectedByRotation = false; 
    public bool isGreenAffectedByRotation = false; 
    public float YellowRotation; 
    public float BlueRotation; 
    public float RedRotation;  
    public float GreenRotation;  
    void Update()
    {
        YellowRotation = blockcheck.rotationValueYellow;
        BlueRotation = blockcheck.rotationValueBlue;
        RedRotation = blockcheck.rotationValueRed;
        GreenRotation = blockcheck.rotationValueGreen;

       
            if(YellowRotation == 90 || YellowRotation == -90 || YellowRotation == 270) { 
                Debug.Log("Affected Yellow"); 
                isYellowAffectedByRotation = true;  
            }  else { 
            isYellowAffectedByRotation = false;
             }


             if(BlueRotation == 90 || BlueRotation == -90 || BlueRotation == 270) { 
                Debug.Log("Affected Blue"); 
                isBlueAffectedByRotation = true;  
            }  else { 
                 isBlueAffectedByRotation = false;
             }

               if(RedRotation == 90 || RedRotation == -90 || RedRotation == 270) { 
                Debug.Log("Affected Blue"); 
                isRedAffectedByRotation = true;  
            }  else { 
                 isRedAffectedByRotation = false;
             }
                if(GreenRotation == 90 || GreenRotation == -90 || GreenRotation == 270) { 
                Debug.Log("Affected Blue"); 
                isGreenAffectedByRotation = true;  
            }  else { 
                 isGreenAffectedByRotation = false;
             }
    }
   


}
