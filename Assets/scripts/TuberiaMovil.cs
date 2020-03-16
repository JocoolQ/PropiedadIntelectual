using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuberiaMovil : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	float rotate = 90.0f;
	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (-moveHorizontal, moveVertical,0.0f );
		//rb.AddForce (movement * speed);
		rb.MovePosition (rb.position + movement*0.1f);
	}

	void Update(){
		//Input.g
		if (Input.GetMouseButtonUp (0)){
			transform.Rotate(new Vector3(0.0f,0.0f,rotate));
			//rotate += 90.0f;
		}
	}
}
