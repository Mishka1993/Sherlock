using UnityEngine;
using System.Collections;

public class AnimTrigger1 : MonoBehaviour {

	
	public GameObject PlaceImage;
	public GameObject Foot1;
	public GameObject Foot2;


	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			PlaceImage.SetActive(true);
		}
	}
}