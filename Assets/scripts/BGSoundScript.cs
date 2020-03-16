using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGSoundScript : MonoBehaviour {

    int indexScene;
    int totalScenes;
    int middleScene;
    // Use this for initialization
    void Start () {
		
	}

    //Play Global
    private static BGSoundScript instance = null;
    public static BGSoundScript Instance
    {
        get { return instance; }
    }

    void Awake()
    {

        indexScene = SceneManager.GetActiveScene().buildIndex;
        totalScenes = SceneManager.sceneCountInBuildSettings;
        middleScene = ((totalScenes - 2) / 2) + 2;
        Debug.Log("The actual Scene is: " + indexScene);


        if ((indexScene == middleScene || indexScene ==1 || indexScene == 0)){
            Destroy(GameObject.Find("BG"));
            instance = null;
        }
        

        if (instance != null && instance != this)
        {

            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        
    }
    //Play Global End
    // Update is called once per frame
    void Update () {

        indexScene = SceneManager.GetActiveScene().buildIndex;
        totalScenes = SceneManager.sceneCountInBuildSettings;

        
        if (indexScene == middleScene || indexScene == (totalScenes-1))
        {
            
        }
        else
        {
            this.gameObject.name = "BG";            
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
