using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicaSinFinalizar : MonoBehaviour {

	void awake(){
        if (SceneManager.GetActiveScene().buildIndex < 3)
        {
            DontDestroyOnLoad(this.gameObject);
        }
		
	}
}
