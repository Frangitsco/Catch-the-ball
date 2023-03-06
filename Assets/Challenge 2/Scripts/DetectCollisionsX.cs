using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour{
    //Destroy the ball when it hits the dog
    private void OnTriggerEnter(Collider other){
        Destroy(gameObject);
    }
}
