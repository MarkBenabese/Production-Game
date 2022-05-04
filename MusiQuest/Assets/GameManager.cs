using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;
    public static GameManager instance;

    private void Start()
    {
        instance = this;

        GameObject DialogueBox = GameObject.Find("DialogueBox");
        Dialogue dialogue = DialogueBox.GetComponent<Dialogue>();
       
    }

    void Update()
    {
        if(!startPlaying)
        {
        if(Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }




        if(Dialogue.TransitionNumber == 1)
        {
            SceneManager.LoadScene("DeclanScene");
        }
    }


    void BattleTransition()
    {
        SceneManager.LoadScene("DeclanScene");
    }

   public void NoteHit()
    {
        Debug.Log("Hit on Time");

    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");
    }

}
