using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Required if we want to work with Scenes



public class Trigger : MonoBehaviour
{
    //Creates a variable to work with the Player animations
    public int Sigma;
    void Start() 
    {

    }
    void Update() {

        Sigma = 0;

        //void OnCollisionEnter2D(Collision2D collision) //Function to enable jumping again after landing.
        //{

        //if (collision.gameObject.CompareTag("Ground"))
        if (Input.GetKey("g"))
        {
            Sigma = 1;
        }
    }

}
    
