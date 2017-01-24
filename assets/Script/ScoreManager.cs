using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public GameObject tenPin;
    public Text ResultText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ResultText.text = "Score: " + GetNumDownPins();
    }

    private int GetNumDownPins()
    {
        int DownCount = 0;
        foreach (var pin in tenPin.GetComponentsInChildren<PinScript>())
        {
            if (pin.IsDown())
            {
                DownCount++;
            }
        }

        return DownCount;
    }
}
