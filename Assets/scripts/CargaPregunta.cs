using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargaPregunta : MonoBehaviour {
	public string archivoDelectura;
	public int numPreguntas;
    string cadena = "S";
    int idPregunta = -1;
    string respuestaCorrecta = "R";
    string pregunta = "P";
    string[] respuestas = new string[4];

    // Use this for initialization
    void Start () {
        lecturaArchivo();
        Text txt = GetComponent<Text>();
        txt.text = cadena;
        GameObject gmb= GameObject.Find("Id");
        Text txtId = gmb.GetComponent<Text>();
        txtId.text = idPregunta.ToString();
        txtId.enabled = false;
        gmb = GameObject.Find("RC");
        Text txtRC = gmb.GetComponent<Text>();
        txtRC.text = respuestaCorrecta;
        txtRC.enabled = false;
    }

    void lecturaArchivo()
    {
		StreamReader objReader = new StreamReader(archivoDelectura);
        string sLine = "";
        List<string> arrText = new List<string>();

        while (sLine != null)
        {
            sLine = objReader.ReadLine();
            if (sLine != null)
                arrText.Add(sLine);
        }
        objReader.Close();

        
        System.Random rnd = new System.Random();

		idPregunta = rnd.Next(1, numPreguntas+1); //Random number between 1-21

        string numP = idPregunta.ToString();

        int indexP = arrText.IndexOf(numP);
        respuestaCorrecta= arrText[indexP + 1];
        pregunta = arrText[indexP + 2];
        cadena = pregunta;
		for(int i=0; i<4; i++)
		{
			respuestas[i] = arrText[indexP + (3+i)];
			cadena += "\n"+ respuestas[i];
		}

    }
    // Update is called once per frame
    void Update () {
		
	}
}
