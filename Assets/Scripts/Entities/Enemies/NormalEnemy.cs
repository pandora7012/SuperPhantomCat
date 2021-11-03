using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : MonoBehaviour
{

    [SerializeField] protected Rigidbody2D rb;
    [SerializeField] protected int Direction;
    [SerializeField] protected float speed;


    private void Start()
    {
        Direction = -1; 
    }

    protected virtual void Update()
    {
        Run();
    }

    [System.Obsolete]
    public void revertDirection()
    {
        Direction *= -1;
        transform.rotation = Direction == -1 ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(0, 180, 0);
    }

    private void Run()
    {
        rb.position += new Vector2(speed * Time.deltaTime * Direction, 0);
    }

    public void Dead()
    {
        Destroy(this.gameObject);
        Debug.Log("Destroy");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Player dead");
        }
    }

}
