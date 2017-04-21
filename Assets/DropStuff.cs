using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropStuff : MonoBehaviour {

	public List<GameObject> _items = new List<GameObject>();
	public int amount;

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			_items [0].GetComponent<Rigidbody> ().useGravity = true;
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			_items [1].GetComponent<Rigidbody> ().useGravity = true;
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			_items [2].GetComponent<Rigidbody> ().useGravity = true;
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			_items [3].GetComponent<Rigidbody> ().useGravity = true;
		}
	}
	public void OnHit(int numb){
		amount += numb;
	}
}
