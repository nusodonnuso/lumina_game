using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyCollision : MonoBehaviour
{
    public Transform checkpoint; // Referencia al objeto del checkpoint

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reposiciona al jugador en el checkpoint
            collision.gameObject.transform.position = checkpoint.position;
        }
    }
}

