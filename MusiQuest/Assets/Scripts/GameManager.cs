using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;
    public static GameManager instance;
    public int currentScore;
    public int scorePerNote = 100;
    public int currentMultiplier;
    public int multiplierTracker;
    public Text scoreText;
    public Text multiText;
    public int[] multiplierThresholds;
    public EnemyStats enemyStats;
    public CharacterSwitch characterSwitch;



    private void Start()
    {
        instance = this;

        scoreText.text = "Score: 0";

        GameObject DialogueBox = GameObject.Find("DialogueBox");
        Dialogue dialogue = DialogueBox.GetComponent<Dialogue>();

        currentMultiplier = 0;
        
       
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




        if(Dialogue.TransitionNumber == 1 && characterSwitch.CharacterChange == 1)
        {
            SceneManager.LoadScene("DeclanScene");
        }
       else if (Dialogue.TransitionNumber == 1 && characterSwitch.CharacterChange == 3)
        {
            SceneManager.LoadScene("DeclanScene3");
        }
        else if(Dialogue.TransitionNumber == 1 && characterSwitch.CharacterChange == 2)
        {
            SceneManager.LoadScene("DeclanScene4");
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("DeclanScene2");
    }
   /* public void BattleTransition()
    {
        SceneManager.LoadScene("DeclanScene");
    }*/

   public void NoteHit()
    {
        Debug.Log("Hit on Time");

        enemyStats.TakeDamage(currentScore);
        if (currentMultiplier - 1 < multiplierThresholds.Length)
        {


            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }


        multiText.text = "Multiplier: x" + currentMultiplier.ToString();
        currentScore += scorePerNote * currentMultiplier;
        
        scoreText.text = "Score:" + currentScore.ToString();

    }

    public void NoteMissed()
    {
        currentMultiplier = 1;
        Debug.Log("Missed Note");
    }

}
