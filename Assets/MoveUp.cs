using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour {
	public DropStuff dropstuff;
	public int speed;
	// Use this for initialization
	void Start () {
		dropstuff = GameObject.FindObjectOfType<DropStuff> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (dropstuff.amount == 4) {
			transform.position += new Vector3 (0, speed, 0);
		}
	}
}
