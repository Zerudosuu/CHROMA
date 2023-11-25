using System;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    public float xOffset;
    public float yOffset;
    public float offsetSmoothing;

   public float distanceBelowCamera = 5f;

    // private Vector3 velocity = Vector3.zero;

    void Start()
    {
        // // Set the initial camera position including the desired Z offset
        // transform.position = new Vector3(transform.position.x, transform.position.y, -20f);
    }

   void Update()
{
    float destroyY = transform.position.y - distanceBelowCamera;

    if (player.position.y < destroyY || 
        player.position.x < transform.position.x - 10f || 
        player.position.x > transform.position.x + 10f) 
    {
        Debug.Log("Destroyed or Trigger Action!");
        // Add code here to destroy the player or trigger an action
    }
}
    
    void LateUpdate() 
{
    
    if(player.position.y > transform.position.y) { 
        Vector3 newPosition = new Vector3(transform.position.x, player.position.y, transform.position.z);
        transform.position = newPosition;
    }

  
}

}
