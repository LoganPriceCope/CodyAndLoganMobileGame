using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro_script : MonoBehaviour
{
    Vector3 rot;
    // Start is called before the first frame update
    void Start()
    {
        rot = Vector3.zero;
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Input.gyro.enabled = true;

        transform.rotation = GyroToUnity(Input.gyro.attitude);

        //rot.y = Input.gyro.rotationRateUnbiased.y;
        Debug.Log(Input.gyro.attitude);
        transform.Rotate(rot);
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        // has to b in the order up and down, forwards and back, left and right.
        return new Quaternion(q.x, -q.z, q.y, -q.w);
    }

    // this is just printing it to the screen
    protected void OnGUI()
    {
        GUI.skin.label.fontSize = Screen.width / 40;

        GUILayout.Label("Orientation: " + Screen.orientation);
        GUILayout.Label("input.gyro.attitude: " + Input.gyro.attitude);
        GUILayout.Label("iphone width/font: " + Screen.width + " : " + GUI.skin.label.fontSize);

        GUILayout.Label("supports gyro= " + SystemInfo.supportsGyroscope);
    }
}