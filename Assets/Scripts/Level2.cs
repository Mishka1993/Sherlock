using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour {
	public GameObject Foot;
	public GameObject Obj;

	public GameObject Obj1;

	void  OnMouseDown() {
		Foot.SetActive(true);
		Obj.SetActive(false);
		Obj1.SetActive(true);
	}  
}
