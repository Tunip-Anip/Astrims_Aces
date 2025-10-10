using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement; //Important, if working with scenes you MUST include this.


public class Invincible : MonoBehaviour
{
    private CircleCollider2D enemyCollider;
    private IEnumerator coroutine;



    // Start is called before the first frame update
    void Start()
    {
        enemyCollider = GetComponent<CircleCollider2D>();
    }

    // This method is called when a collision with another Collider2D occurs.
    //void OnCollisionEnter2D(Collision2D target)
    //{
        // Check if the colliding GameObject has the "Deadly" tag
      //  if (target.gameObject.CompareTag("Player"))
        //{

            // Disable the CapsuleCollider2D on the Player to prevent further collisions
          //  if (enemyCollider != null)
            //{
              //  enemyCollider.enabled = false;

//            }
  //      }
    //}
     IEnumerator OnCollisionEnter2D(Collision2D target)
    {
        while (true)
        {
            if (target.gameObject.CompareTag("Player"))
            {

                // Disable the CapsuleCollider2D on the Player to prevent further collisions
                if (enemyCollider != null)
                {
                    enemyCollider.enabled = false;
                }
                yield return new WaitForSeconds(1);
                if (enemyCollider = null)
                {
                    enemyCollider.enabled = true;
                }
            }
        }
    }
}