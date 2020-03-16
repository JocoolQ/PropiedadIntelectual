using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController2 : MonoBehaviour {


	public Text gameOverText;
	public Text iniciarText;
	public GameObject panel;
	public GameObject parti;
	public GameObject cajatxt;
	public GameObject botonGO;
	public GameObject biniciar;
	public GameObject cargar;

	void Start () {
		botonGO.gameObject.SetActive (false);
		parti.gameObject.SetActive (false);
		panel.gameObject.SetActive (false);
		gameOverText.gameObject.SetActive (false);
		cajatxt.gameObject.SetActive (false);
	}

	public void iniciar(){
		iniciarText.gameObject.SetActive(false);
		biniciar.gameObject.SetActive (false);
		botonGO.gameObject.SetActive (true);
		parti.gameObject.SetActive (true);
		panel.gameObject.SetActive (true);
		cajatxt.gameObject.SetActive (true);
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