using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour {
    // This method is called when the ball hits the dog
    private void OnTriggerEnter(Collider other) {
        // Increase the score when the ball is caught
        FindObjectOfType<GameManager>().IncreaseScore();

        // Destroy the ball
        Destroy(gameObject);
    }
}

