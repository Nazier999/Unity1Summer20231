using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderScript : MonoBehaviour
{
    [SerializeField]
    Vector3 startPos;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10) {
            transform.position = startPos;
            rb.velocity = Vector3.zero;// same as sayying new Vector3(0,0,0);
            rb.AddForce(Vector3.up * Random.Range(500f, 1000f));
        }
        
    }
}
