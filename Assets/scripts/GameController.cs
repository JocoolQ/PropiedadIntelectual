using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {


	public Text gameOverText;
	public Text iniciarText;
	public GameObject panel;
	public GameObject parti;
	public GameObject boton1;
	public GameObject boton2;
	public GameObject boton3;
	public GameObject boton4;
	public GameObject biniciar;
	public GameObject cargar;

	void Start () {
		boton1.gameObject.SetActive (false);
		boton2.gameObject.SetActive (false);
		boton3.gameObject.SetActive (false);
		boton4.gameObject.SetActive (false);
		parti.gameObject.SetActive (false);
		panel.gameObject.SetActive (false);
		gameOverText.gameObject.SetActive (false);
	}
		
	public void iniciar(){
		iniciarText.gameObject.SetActive(false);
		biniciar.gameObject.SetActive (false);
		boton1.gameObject.SetActive (true);
		boton2.gameObject.SetActive (true);
		boton3.gameObject.SetActive (true);
		boton4.gameObject.SetActive (true);
		parti.gameObject.SetActive (true);
		panel.gameObject.SetActive (true);
	}

	public void cargarEscena(){
		cargar.gameObject.SetActive (true);
	}

	public void terminarJuego(){
		Debug.Log ("Saliendo");
		Application.Quit ();
	}

	void Update () {
	}
}
