using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Head : MonoBehaviour
{
    [SerializeField] private NormalEnemy enemy;

    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tile"))
            enemy.revertDirection();
    }
}
