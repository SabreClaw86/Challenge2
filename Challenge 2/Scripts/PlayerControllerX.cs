using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delay = 0f;
    // Update is called once per frame
    void Update()
    {

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && delay == 0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            delay = 2f;

        }
        if (delay > 0) delay -= Time.deltaTime;
        else if (delay < 0f) delay = 0f;

    }
}
