using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundTrack : MonoBehaviour {
    public AudioSource pista;
    // Use this for initialization
    void Start(){
        pista.loop = true;
        pista.Play();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
