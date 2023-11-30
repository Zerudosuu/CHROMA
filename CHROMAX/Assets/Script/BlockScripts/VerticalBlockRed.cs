using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VerticalBlockRed : MonoBehaviour
{
    public GameObject player;
    Collider2D redCollider;

    void Start()
    {
        redCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (player.transform.position.x <= gameObject.transform.position.x)
        {
            // Player is on or left of the block, disable collider
            redCollider.enabled = false;
        }
        else
        {
            // Player is to the right of the block, enable collider
            redCollider.enabled = true;
        }
    }
}
