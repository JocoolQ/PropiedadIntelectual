using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteVolume : MonoBehaviour {
    
	// Use this for initialization
	public void MuteMasterVolume() { 
    
        Toggle toggle= gameObject.GetComponent<Toggle>();

        AudioListener.pause = toggle.isOn;
        
        
    }
}
