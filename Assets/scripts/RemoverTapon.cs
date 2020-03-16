using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoverTapon : MonoBehaviour {
	public GameObject explosion;
	public GameObject explosion2;
	public GameObject explosion3;
	public GameObject tubo;
	public GameObject toro;
	public GameObject boton;
	public GameObject salir;

	public Text continuar;
	public Text gameOver;

	public GameObject carga;

	string cadena="S";
	public string opcion="";
	// Use this for initialization
	void Start () {
        cadena = "S";
        StartCoroutine(esperar());
        float xT= transform.localScale.x;
        xT -= 0.23f;
        float zT= transform.localScale.z;
        zT -= 0.23f;
        float yT= transform.localScale.y;
        transform.localScale= new Vector3(xT,yT,zT) ;
	}
    
    IEnumerator esperar(){
    	 yield return new WaitForSeconds(0.5f);
    }

	void comprobarRespuesta(){
        GameObject gmb= GameObject.Find("RC");
        Text txtRC = gmb.GetComponent<Text>();
        cadena=txtRC.text;
	}

	public void removerTapon(){
		comprobarRespuesta ();
		Update ();
	}

	// Update is called once per frame
	void Update () {
        if (cadena != "S")
        {
            GameObject[] botones;
            botones = GameObject.FindGameObjectsWithTag("Button");

            foreach (GameObject boton in botones)
            {
                Button btn = boton.GetComponent<Button>();
                btn.interactable = false;
            }
            
		}
        
    }
	void OnCollisionEnter(Collision collision){
		GameObject[] tapones = new GameObject[4];
		tapones[0] = GameObject.Find("taponA");
		tapones[1] = GameObject.Find("taponB");
		tapones[2] = GameObject.Find("taponC");
		tapones[3] = GameObject.Find("taponD");
		if (cadena == opcion) {
			carga.gameObject.SetActive (true);
			continuar.gameObject.SetActive (true);
		} else {

			Instantiate (explosion, transform.position, transform.rotation);
			Instantiate (explosion2, tubo.transform.position, tubo.transform.rotation);
			Instantiate (explosion3, toro.transform.position, toro.transform.rotation);
			Destroy (tubo);
			Destroy (toro);
			Destroy (boton);
			Destroy (gameObject);
			gameOver.gameObject.SetActive (true);
			salir.gameObject.SetActive (true);

		}
		Destroy (tapones[0]);
		Destroy (tapones[1]);
		Destroy (tapones[2]);
		Destroy (tapones[3]);
	}

}
