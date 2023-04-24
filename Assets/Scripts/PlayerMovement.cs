using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{

    // public then can be edited by Unity GUI else not
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get inputs "A", "S", "D", "W"
        float h = Input.GetAxis("Horizontal"); // A, D
        float v = Input.GetAxis("Vertical"); // S, W

        transform.position += new Vector3(h * speed * Time.deltaTime, v * speed * Time.deltaTime,0);

        // Debug.Log(transform.position);
    }
}
