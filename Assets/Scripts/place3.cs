﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class place3 : MonoBehaviour {
	public GameObject StartImage;
	public GameObject Place;

	
	void OnMouseDown() {
		StartImage.SetActive(false);
		Destroy(Place);
	}
}

