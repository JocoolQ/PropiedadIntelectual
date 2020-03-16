using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLimitTaponMSuperior : MonoBehaviour {

	public GameObject generador;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "particula") {
			Destroy(GameObject.Find("taponM"));
			generador.gameObject.SetActive (false);
		}
	}
}
