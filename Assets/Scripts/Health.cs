using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement; //Important, if working with scenes you MUST include this.


public class Health : MonoBehaviour
{
    public EnemyHit script;
    public GameObject target;

    private Transform t;

    public Animator animator; //Creates a variable to work with the Player animations

    // Start is called before the first frame update
    void Start()
    {
        animator.SetInteger("HealthState", 5);
        t = target.transform;


    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("HealthState", EnemyHit.Hearts);
        if (target != null)
        {
            transform.position = new Vector3(t.position.x - 20, t.position.y + 13, transform.position.z); //This creates a camera vector which follows the player.

        }
        if (EnemyHit.Hearts < 1)
        {
            SceneManager.LoadScene("SplashScreen");

        }
    }
}