using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManager : MonoBehaviour {

    public GameObject starShip;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {

        // Check if the p key was pressed
        if (Input.GetButtonDown("p")) {
            // Check if the component is enabled or disabled
            if (GetComponent<ShipMover>().enabled == true) {
                // Disable the component
                GetComponent<ShipMover>().enabled = false;
            } else {
                // Enable the component
                GetComponent<ShipMover>().enabled = true;
            }
        }

        // Check if the q key was pressed
        if (Input.GetButtonDown("q")) {
            // Disable the whole game object
            starShip.SetActive(false);
        }

        // Check if the quit key was pressed
        if (Input.GetButtonDown("quit")) {
            // Safely quit the application
            Application.Quit();
        }
    }
}
