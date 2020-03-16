using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class removerTapon2 : MonoBehaviour {
	public GameObject explosion;
	public GameObject explosion2;
	public GameObject explosion3;
	public GameObject toro;
	public GameObject toro2;
	public GameObject tapa;
	public Button botonGO;
	public GameObject salir;
	public GameObject tuberia;
	public Text continuar;
	public Text gameOver;

	public GameObject carga;

	string cadena="S";
	string respuesta="";
	// Use this for initialization
	void Start () {
		cadena = "S";
	}

	void comprobarRespuesta(){
		GameObject gmb= GameObject.Find("RC");
		Text txtRC = gmb.GetComponent<Text>();
		cadena=txtRC.text;
	}

	public void cargarRespuesta(){
		comprobarRespuesta ();
		GameObject gmb2= GameObject.Find("resp");
		Text txtResp = gmb2.GetComponent<Text>();
		respuesta = "&"+txtResp.text;
		Update ();
	}

	// Update is called once per frame
	void Update () {
		if (cadena != "S")
		{
			botonGO.interactable = false;
		}
	}

	void OnCollisionEnter(Collision collision){

		if (cadena == respuesta) {
			tuberia.transform.position = new Vector3 (-4.92f, 2.34f, -1.53f);
			tuberia.transform.eulerAngles= new Vector3 (0, 0, 180.96f);
			Destroy (tapa);
			carga.gameObject.SetActive (true);
			continuar.gameObject.SetActive (true);


		} else {
			GameObject cilindro= GameObject.Find("CylinderA");
			GameObject toro3= GameObject.Find("TorusA");
			Instantiate (explosion, transform.position, transform.rotation);
			Instantiate (explosion2, toro2.transform.position, toro2.transform.rotation);
			Instantiate (explosion3, toro.transform.position, toro.transform.rotation);
			Instantiate (explosion, cilindro.transform.position, cilindro.transform.rotation);
			Instantiate (explosion2, toro3.transform.position, toro3.transform.rotation);
			Instantiate (explosion3, tapa.transform.position, tapa.transform.rotation);
			Destroy (toro);
			Destroy (toro2);
			Destroy (botonGO);
			Destroy (toro3);
			Destroy (cilindro);
			Destroy (tapa);
			Destroy (gameObject);
			gameOver.gameObject.SetActive (true);
			salir.SetActive (true);

		}
	}
		
}
