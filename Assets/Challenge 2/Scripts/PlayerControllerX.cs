using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float timeStart = 0.0f;
    private float timeRepeat = 1.0f;
    private bool acceptInput = false;

    private void Start()
    {
        InvokeRepeating("SetAcceptInput", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && acceptInput)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            acceptInput = false;
        }
    }

    private void SetAcceptInput()
    {
        acceptInput = true;
    }
}
