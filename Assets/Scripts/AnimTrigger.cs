using UnityEngine;
using System.Collections;

public class AnimTrigger : MonoBehaviour {
	public Animator AnimWail;
	void Start () {
		AnimWail.enabled = false;
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			AnimWail.enabled = true;
			AnimWail.Rebind ();
			AnimWail.SetTrigger ("Play");
		}
	}
}