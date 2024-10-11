using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject camera;
    public GameObject playerObject;

    public float playerPos;
    public float cameraPosX;

    public Vector3 position;
    void Start()
    {
        cameraPosX = camera.transform.position.x;


    }

    // Update is called once per frame
    void Update()
    {

        playerPos = playerObject.transform.position.x;

        position = new Vector3((playerPos - 5), 3, 0);


       // Vector3 cameraPosition = new Vector3(playerPos, position);

        camera.transform.localPosition = position;
    }
}
