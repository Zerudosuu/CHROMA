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


private float RedRotation; 


  void Start() { 

        yellowCollider = YellowBlock.GetComponent<BoxCollider2D>();
        blueCollider = BlueBlock.GetComponent<BoxCollider2D>();
        redCollider = RedBlock.GetComponent<BoxCollider2D>();
        greenCollider = GreenBlock.GetComponent<BoxCollider2D>();

        RedRotation = YellowBlock.transform.rotation.eulerAngles.z;


  }


  void Update() { 

     if (blockcheck.isRedCollided && (RedRotation == 0 && (blockcheck.rotationValueRed == -90 || blockcheck.rotationValueRed == 270)))
        {
    Debug.Log("Activating Red");
    }

    Debug.Log("RedRotation "+ blockcheck.rotationValueRed); 
    Debug.Log("Redblock "+ RedRotation); 

  }

}
