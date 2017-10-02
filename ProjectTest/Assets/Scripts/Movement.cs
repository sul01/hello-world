using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//speed 5->7

public class Movement : MonoBehaviour {

    private Rigidbody2D rb;
    private float speed=7;
    private float hori, verti;

	// Use this for initialization
	void Start ()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        hori = Input.GetAxis("Horizontal");
        verti = Input.GetAxis("Vertical");
	}

    void FixedUpdate()
    {
        Vector3 move = new Vector3(hori, verti, 0);
        rb.velocity = move * speed;
    }
}
