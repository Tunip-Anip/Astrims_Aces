using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    
    public Vector2 enemymoving = new Vector2(); // Public variable to store enemy's movement direction
    public bool Touch;
    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be placed here
        enemymoving.x = enemymoving.y = 1;
        Touch = false;

    }

    // Update is called once per frame
        void OnTriggerEnter2D(Collider2D target) 
    {


        enemymoving.x = enemymoving.x * -1;
        Touch = true;

    }
}