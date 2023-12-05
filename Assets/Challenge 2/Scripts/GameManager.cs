using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public int score = 0;
    public int lives = 3;

    void Start() {
        // Display initial lives and score
        Debug.Log("Lives: " + lives + " | Score: " + score);
    }

    public void IncreaseScore() {
        score++;
        Debug.Log("Score: " + score);
    }

    public void LoseLife() {
        lives--;
        Debug.Log("Lives: " + lives);

        if (lives <= 0) {
            GameOver();
        }
    }

    void GameOver() {
        Debug.Log("Game Over! Your final score: " + score);
        // Add additional game over logic here
    }
}
