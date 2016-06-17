using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3 (0, 0, -10f);
	}

	void Update () {
		if (transform.position.z < -3) {
			Destroy (transform.parent.gameObject);
		}
	}
}
