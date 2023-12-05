using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour {
    private float leftLimit = -37;
    private float bottomLimit = -1;

    void Update() {
        // Check if the GameObject has gone past the left limit
        if (transform.position.x < leftLimit) {
            Destroy(gameObject); // Destroys the GameObject if it goes past the left limit
        } 
        // Check if the GameObject has fallen past the bottom limit
        else if (transform.position.y < bottomLimit) {
            // If the GameObject is a ball, decrease a life
            if (gameObject.CompareTag("Ball")) {
                FindObjectOfType<GameManager>().LoseLife();
            }
            Destroy(gameObject); // Destroys the GameObject if it goes past the bottom limit
        }
    }
}

