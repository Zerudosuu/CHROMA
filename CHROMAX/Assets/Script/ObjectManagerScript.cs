using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManagerScript : MonoBehaviour
{
  public BlockChecking blockcheck; 

  public GameObject YellowBlock; 
  public GameObject BlueBlock; 
  public GameObject RedBlock; 
  public GameObject GreenBlock; 


private Collider2D yellowCollider; 
private Collider2D blueCollider; 
private Collider2D redCollider; 
private Collider2D greenCollider;  


public float BlueRotation; 

public float RedRotation; 
public float YellowRotation; 
public float GreenRotation; 


  void Start() { 

        yellowCollider = YellowBlock.GetComponent<BoxCollider2D>();
        blueCollider = BlueBlock.GetComponent<BoxCollider2D>();
        redCollider = RedBlock.GetComponent<BoxCollider2D>();
        greenCollider = GreenBlock.GetComponent<BoxCollider2D>();

  }

void Update() { 

    RedRotation = blockcheck.rotationValueRed;
    BlueRotation = blockcheck.rotationValueBlue;
    YellowRotation = blockcheck.rotationValueYellow;
    GreenRotation = blockcheck.rotationValueGreen;

    if (RedRotation == 90 || RedRotation == 270 || RedRotation == -90 ) { 
        redCollider.enabled = false;
    } else {
        redCollider.enabled = true; 
    }

      if (BlueRotation == 90 || BlueRotation == 270 || BlueRotation == -90) { 
        blueCollider.enabled = false;
    } else {
        blueCollider.enabled = true; 
    }

      if (YellowRotation == 90 || YellowRotation == 270 || YellowRotation == -90) { 
        yellowCollider.enabled = false;
    } else {
        yellowCollider.enabled = true; 
    }

      if (GreenRotation == 90 || GreenRotation == 270 || GreenRotation == -90) { 
        greenCollider.enabled = false;
    } else {
        greenCollider.enabled = true; 
    }

}


}
