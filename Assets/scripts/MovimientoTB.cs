using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTB : MonoBehaviour {

	public float speed;
	public float XPos= -1.71f;
	Vector3 target;

	// Use this for initialization
	void Start () {
		//target = transform.position;
	}
	public void moverA(){
		XPos = 3.23f;
		Update ();
	}
	public void moverB(){
		XPos = 0.08f;
		Update ();
	}
	public void moverC(){
		XPos = -3.62f;
		Update ();
	}
	public void moverD(){
		XPos = -7.12f;
		Update ();
	}
	// Update is called once per frame
	void Update () {
		//if (Input.GetMouseButtonDown (0)){
			target.x = XPos;
			target.z = -1.06f;
			target.y = 8.15f;
		//}
		transform.position = Vector3.MoveTowards (transform.position,target,speed*Time.deltaTime);
		Debug.DrawLine (transform.position, target, Color.green);
	}

}
