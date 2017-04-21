using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCheck : MonoBehaviour {
	public DropStuff dropstuff;
	public List<GameObject> _books = new List<GameObject>();
	public List<GameObject> _places = new List<GameObject>();

	void Start () {
		dropstuff = dropstuff.GetComponent<DropStuff> ();
	}
	
	void Update () {
		
	}
}
