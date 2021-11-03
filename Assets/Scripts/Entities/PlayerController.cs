using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("Physics")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int jumpPower;
    [SerializeField] private int speed;
    public enum direction
    {
        MoveRight,
        MoveLeft,
        Idle
    }
    private bool isLanding; 


    private direction direc; 

    void Start()
    {
        InitThis();
        direc = direction.Idle;
        isLanding = true;
    }

    private void InitThis()
    {
        rb.angularVelocity = 0;
    }

    private void FixedUpdate()
    {
        Moving();
        isLanding = this.rb.velocity.y == 0; 
    }


    #region Move 

    private void Moving()
    {
        if (direc == direction.MoveLeft)
            rb.position += new Vector2(-speed * Time.deltaTime, 0);
        else if (direc == direction.MoveRight)
            rb.position += new Vector2(speed * Time.deltaTime, 0);
        else
        {
            direc = direction.Idle;
            if (isLanding) rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    public void Jump()
    {
        if (!isLanding)
            return;

        rb.AddForce(new Vector2(0,jumpPower));
        isLanding = false; 
    }

    public void SetMove(direction dic)
    {
        direc = dic;
    }

    #endregion

    
    
}
