using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Kill : MonoBehaviour
{
    [SerializeField] private NormalEnemy enemy;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")){
            collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1500));
            enemy.Dead();
        }
        
    }
}
