using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupCamera : MonoBehaviour
{

    public Camera FollowCam;
    public Camera StaticCam;
 
    void Start()
    {

        GameObject PlayerCharacter = GameObject.FindGameObjectWithTag("Player");

        FollowCam.enabled = true;
        StaticCam.enabled = false;

        PlayerCharacter.GetComponent<AudioListener> ().enabled = true;
        StaticCam.GetComponent<AudioListener> ().enabled = false;

    }

  
}
