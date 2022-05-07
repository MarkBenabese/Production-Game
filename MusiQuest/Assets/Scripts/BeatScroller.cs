using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted;



    public void Start()
    {
        beatTempo = beatTempo / 60f;
    }



    public void Update()
    {
        
        if(!hasStarted)
        {
            if(Input.anyKeyDown)
            {
                hasStarted = true;
            }

        }
        else
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }

        if(transform.position.y < -35)
        {
            Debug.Log("loopnow");
            transform.position = new Vector3(-0.4072742f, 6f);
        }
      
    }
}
