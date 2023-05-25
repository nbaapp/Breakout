using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatScript : MonoBehaviour
{
    public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") && transform.position.x < 38.15)
        {
            transform.position = transform.position + new Vector3(moveSpeed, 0 ,0) * Time.deltaTime;
        }
        if (Input.GetKey("a") && transform.position.x > -33.65)
        {
            transform.position = transform.position - new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
        }
    }
}
