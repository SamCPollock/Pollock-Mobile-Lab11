using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_CheckpointTrigger : MonoBehaviour
{
    public Transform spawnPoint;
    private GameController gameController;
    void Start()
    {
        gameController = GameController.FindObjectOfType<GameController>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameController.SetCurrentSpawnPoint(spawnPoint);
        }
    }
}
