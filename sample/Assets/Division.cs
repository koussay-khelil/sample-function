using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Division : MonoBehaviour {

    // Use this for initialization
    public int a;
    public int b;
    void division()
    {
        Debug.Log(a / b);
    }
	void Start () {
        division();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
