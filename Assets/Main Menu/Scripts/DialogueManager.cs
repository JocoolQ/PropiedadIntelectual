using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour {

    private Queue<string> sentences;
    public Text nameText;
    public Text dialogueText;
    string sentence;
    string nombreJugador="default";
    public Text inputText;
    bool activePanel = false;

    public Animator animator;
    public GameObject namePanel;

    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;

    // Use this for initialization
    void Start () {
        sentences = new Queue<string>();
	}

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string stnc in dialogue.sentences)
        {
            sentences.Enqueue(stnc);
        }

        DisplayNextSentence();
    }

    public void LoadByIndex(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            slider.value = progress;
            progressText.text = progress * 100f + "%";

            yield return new WaitForSeconds(0.1f);

        }

    }

    IEnumerator WaitTime(float timeW)
    {
        yield return new WaitForSeconds(timeW);
    }

    public void DisplayNextSentence()
    {

        if (sentence == "¿Quién eres?" && !activePanel)
        {
            activePanel = true;
            namePanel.SetActive(true);

        }
        else if (sentence=="Buena suerte!")
        {
            EndDialogue();
            StartCoroutine(WaitTime(2.0f));
            LoadByIndex(2);
        }
        else
        {
            


            if (sentences.Count == 0)
            {
                EndDialogue();
                return;
            }

            sentence = sentences.Dequeue();

            if (sentence.Contains("NNNN"))
            {
                nombreJugador = inputText.text;
                sentence= sentence.Replace("NNNN",nombreJugador);
                
            }

            if (sentence.Contains("Winsey") || nameText.text=="")
            {
                nameText.text = "Winsey";
            }

            if (sentence.Contains("\"") || sentence.Contains("*"))
            {
                nameText.text = "";
            }

            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));

            
        }

    }

    IEnumerator TypeSentence(string sentence)
    {
       
        dialogueText.text = "";
        
        
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            if (letter == '.')
            {
                yield return new WaitForSeconds(.2f);
            }
            else
            {
                yield return new WaitForSeconds(.01f);
            }
            
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }
}
