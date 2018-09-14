using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceScene1 : MonoBehaviour {

    public float thrust = 0.0f;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * thrust);
    }

}
