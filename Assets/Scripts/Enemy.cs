using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement; //Required if we want to work with Scenes

public class Enemy : MonoBehaviour
{
    public float speed = 150f; //Stores player speed as a float
    public Vector2 maxVelocity = new Vector2(60, 100); //Stores player velocity (60x, 100y)
    private Rigidbody2D body2D; //Creates a variable for the RigidBody2D component
    private SpriteRenderer renderer2D; //Creates a variable to render the sprite
    private EnemyController controller; //Creates a variable for the controller (created in a separate script)
    public Animator animator; //Creates a variable to work with the Player animations

    AudioSource audioData;

    /*//Starts before the first frame. Gets the RigidBody2D, SpriteRenderer, PlayerController 
    and Animator from the Player sprite and stores them in relevant variables*/
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
        controller = GetComponent<EnemyController>();
        animator = GetComponent<Animator>();
        audioData = GetComponent<AudioSource>();

    }
    private float GetVerticalSpeed() => body2D.linearVelocity.y;
    void Update()
    {
        var absVelX = Mathf.Abs(body2D.linearVelocity.x); //Creates a variable to store horizontal movement velocity (x)



        if (!PauseMenu.isPaused)
        {
            var forceX = 0f;

            if (controller.enemymoving.x != 0) //Check if the player is enemymoving horizontally
            {

                if (absVelX < maxVelocity.x) //Check if the player's horizontal velocity is within limits and adjust force accordingly
                {
                    var newSpeed = speed * controller.enemymoving.x;

                    forceX = true ? newSpeed : (newSpeed * 1);

                    renderer2D.flipX = forceX < 0;
                }
            }


            body2D.AddForce(new Vector2(forceX, 0 )); //Apply the calculated forces to the player's Rigidbody2D
        }
    }
}
