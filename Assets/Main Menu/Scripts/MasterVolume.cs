using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterVolume : MonoBehaviour {

	public void ChangeVolume () {
        Slider slider= gameObject.GetComponent<Slider>();
        AudioListener.volume = slider.value;
	}
}
