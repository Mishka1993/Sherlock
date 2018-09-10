using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	public GameObject True;
	public GameObject test;

	
	void OnMouseDown() {
		True.SetActive(true);
		test.SetActive(false);
	}

	// Use this for initialization
	
}
