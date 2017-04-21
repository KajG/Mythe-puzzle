using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book1 : MonoBehaviour {

	public DropStuff dropstuff;

	void Start () {
		dropstuff = dropstuff.GetComponent<DropStuff> ();
	}
	void OnTriggerEnter(Collider cube){
		if (cube.tag == gameObject.tag) {
			dropstuff.OnHit (1);
		}
	}
	void OnTriggerExit(Collider cube){
		if (cube.tag == gameObject.tag) {
			dropstuff.OnHit (-1);
		}
	}
}
