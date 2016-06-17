using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private Rigidbody rb;

	void Awake(){
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Vector3.zero;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.velocity = Vector3.zero;
			rb.AddForce (new Vector3 (0, 300f));
		}
	}
}
