using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private GameObject target;
    public float speed = 10;
    private Vector3 cameraAngle;
    private int zoom = 10;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3(0, zoom, 0);

        if(Input.mouseScrollDelta == new Vector2(0,1))
        {
            zoom -= 1;
        }
        else if (Input.mouseScrollDelta == new Vector2(0, -1))
        {
            zoom += 1;
        }

        // move the camera

        
    }
}
