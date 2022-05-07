using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    private SpriteRenderer PlayerSR;
    public Sprite Guitar;
    public Sprite Piano;
    public Sprite Drum;

    public int CharacterChange;


    void Start()
    {
        PlayerSR = GetComponent<SpriteRenderer>();
        CharacterChange = 1;
    }
    void Update()
    {
        switch (CharacterChange)
        {
            case 1:
                PlayerSR.sprite = Guitar;
                break;

            case 2:
                PlayerSR.sprite = Piano;
                break;

            case 3:
                PlayerSR.sprite = Drum;
                break;

            default:

                break;
        }




        if(Input.GetKeyDown("1"))
        {
            CharacterChange = 1;
        }
        else if (Input.GetKeyDown("2"))
        {
            CharacterChange = 2;
        }
        else if (Input.GetKeyDown("3"))
        {
            CharacterChange = 3;
        }
    }

}

