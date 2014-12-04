using UnityEngine;
using System.Collections;

public class Ninja : MonoBehaviour {

	public Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		MoveCharacter ();
	}

	void MoveCharacter () {

	}
}
