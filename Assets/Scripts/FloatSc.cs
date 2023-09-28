using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatSc : MonoBehaviour
{
    private Vector3 OriginalPoint;
    public float height;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        OriginalPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < OriginalPoint.y)
        {
            speed = -speed;
        }
        else if (transform.position.y > OriginalPoint.y + height)
        {
            speed = -speed;
        }

        transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }
}
