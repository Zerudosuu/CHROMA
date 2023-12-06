using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject player;

    private void Start()
    {
        player.transform.position = spawnPoint.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.SetActive(false);
            Invoke("spawnPlayer", 2.0f);
        }
    }


    private void spawnPlayer()
    {
        player.SetActive(true); 
        player.transform.position = spawnPoint.position;
    }
}
