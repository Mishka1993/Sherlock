using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levev3 : MonoBehaviour {

	public GameObject Obj;

	public GameObject Obj1;

	void  OnMouseDown() {
		Obj.SetActive(false);
		Obj1.SetActive(true);
	}  
}
