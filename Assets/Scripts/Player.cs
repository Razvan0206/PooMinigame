﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{   
    public float JumpForce;
    public float SidewaysForce;
    public bool left;
    public bool right;
    public Rigidbody2D rb;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
          rb.AddForce(transform.up*JumpForce);
          Debug.Log("GroundCollide");
        }
        
        

    }

    void Update()
    {
        //A
        if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            left = false;
        }
        //
        //B
        if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            right = false;
        }
        //
        if(left == true)
        {
          rb.AddForce(transform.right*-SidewaysForce);
          Debug.Log("left");
        }
        if(right == true)
        {
          rb.AddForce(transform.right*SidewaysForce);
          Debug.Log("right");
        }
        if(gameObject.transform.position.y < -10)
        {
            SceneManager.LoadScene (SceneManager.GetActiveScene ().name);


        }


    }

}
