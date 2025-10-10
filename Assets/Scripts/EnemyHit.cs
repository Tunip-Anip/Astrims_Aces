using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Important, if working with scenes you MUST include this.
using UnityEngine.UI;

public class EnemyHit : MonoBehaviour
{
    private CapsuleCollider2D playerCollider;
    public static int Hearts = 5;

    void Start()
    {
        // Get the CapsuleCollider2D component attached to the Player GameObject
        playerCollider = GetComponent<CapsuleCollider2D>();
        Hearts = 5;
    }

    // This method is called when another Collider2D enters the trigger zone of this GameObject.
    void OnTriggerEnter2D(Collider2D target)
    {
        // Check if the entering GameObject has the "Deadly" tag

        if (target.gameObject.CompareTag("Enemy"))
        {

            // Disable the CapsuleCollider2D on the Player to prevent further collisions
            if (playerCollider != null)
            {
                Hearts -= 1;
                
            }
        }
    }
}
