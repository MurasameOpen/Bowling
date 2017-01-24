using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    public float Force;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var h = Input.GetAxis("Horizontal");
        // var v = Input.GetAxis("Vertical");

        if (h != 0.0f)
        {
            var newPosition = new Vector3(transform.position.x + h / 100, transform.position.y, transform.position.z);

            transform.position = newPosition;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            BallFire();
        }
    }

    void BallFire()
    {
        var rigbody = GetComponent<Rigidbody>();

        rigbody.useGravity = true;
        rigbody.AddForce(new Vector3(0.0f, 0.0f, Force * rigbody.mass));
    }
}
