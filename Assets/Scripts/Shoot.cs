using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    
    public Vector2 bullet = new Vector2(); // Public variable to store player's movement direction

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be placed here
    }

    // Update is called once per frame
    void Update()
    {
        // Reset the movement vector to (0, 0) at the start of each frame
        bullet.x = bullet.y = 0;

        // Check if the right arrow key or 'D' key is pressed
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)){
            // Set the x component of the movement vector to 1 (right direction)
            bullet.x = 1;
        }

        
    }
}