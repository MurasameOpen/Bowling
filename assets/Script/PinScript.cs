using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinScript : MonoBehaviour {

    private const float DownAngle = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool IsDown()
    {
        if (Mathf.Abs(transform.rotation.x) < DownAngle && Mathf.Abs(transform.rotation.z) < DownAngle)
        {
            return false;
        }

        return true;
    }
}
