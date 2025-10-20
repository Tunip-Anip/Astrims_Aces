using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Required if we want to work with Scenes



public class Trigger : MonoBehaviour
{
    //Creates a variable to work with the Player animations
    public static bool WallTouch;
    
    void Start()
    {

    }
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D target) //Function to enable jumping again after landing.
    {

        if (target.gameObject.CompareTag("Ground"))
        //if (Input.GetKey("g"))
        {
            WallTouch = true;
        }
    }
    void OnTriggerExit2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("Ground"))
        {
            WallTouch = false;
        }
    }
}
    
