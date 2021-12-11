using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{
    //public Transform playerSpawnPoint;
    private GameController gameController;

    private void Start()
    {
        gameController = GameController.FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = gameController.currentSpawnPoint.position;
        }
        else
        {
            other.gameObject.SetActive(false);
        }

    }
}
