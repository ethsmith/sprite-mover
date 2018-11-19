using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMover : MonoBehaviour {

    // Create a speed variable for editing
    public float speed = 0.5f;
    // Create a variable for our transform component
    private Transform tf;
    // Create a variable that checks if the ship is moving one meter at a time
    private bool movingOneMeter = false;
    // Create a variable that stores the direction that the sprite moves for one meter
    private string direction;

	// Use this for initialization
	void Start () {
        // Load our transform component into our variable
        tf = GetComponent<Transform>();
	}

    // Update is called once per frame
    void Update() {

        /*
            Reset to Origin
            Check if the space bar was pressed, if so, reset the sprite to the center
        */
        if (Input.GetButtonDown("space")) {
            tf.localPosition = new Vector3(0, 0, 0);
        }

        /*
            Disable One Meter Moving
            Check if an arrow was pushed and released, if so, set movingOneMeter to false
        */
        if (Input.GetButtonDown("right") && movingOneMeter) {
            movingOneMeter = false;
        } else if (Input.GetButtonDown("left") && movingOneMeter) {
            movingOneMeter = false;
        } else if (Input.GetButtonDown("up") && movingOneMeter) {
            movingOneMeter = false;
        } else if (Input.GetButtonDown("down") && movingOneMeter) {
            movingOneMeter = false;
        }

        /*
            Enable One Meter Moving
            Check if the shift key is pressed down and an arrow was pushed and released
        */
        if (Input.GetButton("shift") && Input.GetButtonDown("right")) {
            // Set movingOneMeter to true if its false
            if (!movingOneMeter) {
                movingOneMeter = true;
                // set direction
                direction = "right";
            }
        } else if (Input.GetButton("shift") && Input.GetButtonDown("left")) {
            // Set movingOneMeter to true if its false
            if (!movingOneMeter) {
                movingOneMeter = true;
                // set direction
                direction = "left";
            }
        } else if (Input.GetButton("shift") && Input.GetButtonDown("up")) {
            // Set movingOneMeter to true if its false
            if (!movingOneMeter) {
                movingOneMeter = true;
                // set direction
                direction = "up";
            }
        } else if (Input.GetButton("shift") && Input.GetButtonDown("down")) {
            // Set movingOneMeter to true if its false
            if (!movingOneMeter) {
                movingOneMeter = true;
                // set direction
                direction = "down";
            }
        }

        /*
            Move One Meter
        */
        if (movingOneMeter) {
            // Check if the direction was right
            if (direction == "right") {
                // increment one over the x axis
                tf.localPosition += Vector3.right;
            }
            // Check if the direction was left
            else if (direction == "left") {
                // decrement one over the x axis
                tf.localPosition += Vector3.left;
            }
            // Check if the direction was up
            else if (direction == "up") {
                // increment one over the y axis
                tf.localPosition += Vector3.up;
            }
            // Check if the direction was down
            else if (direction == "down") {
                // decrement one over the y axis
                tf.localPosition += Vector3.down;
            }

            return;
        }

        /*
            Move While Pressing and Holding Keys
        */
        // Check if the right arrow was pressed
        if (Input.GetButton("right")) {
            // Move right 0.5 on the x axis
            tf.localPosition += (Vector3.right * speed);
        // Check if the left arrow was pressed
        } else if (Input.GetButton("left")) {
            // Move left 0.5 on the x axis
            tf.localPosition += (Vector3.left * speed);
        // Check if the up arrow was pressed
        } else if (Input.GetButton("up")) {
            // Move up 0.5 on the y axis
            tf.localPosition += (Vector3.up * speed);
        // Check if the down arrow was pressed
        } else if (Input.GetButton("down")) {
            // Move down 0.5 on the y axis
            tf.localPosition += (Vector3.down * speed);
        }
	}
}
