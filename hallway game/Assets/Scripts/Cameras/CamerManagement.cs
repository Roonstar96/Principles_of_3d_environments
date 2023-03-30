using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerManagement : MonoBehaviour
{
    public Camera MainCam;
    public Camera TrapCam;
    public Camera LiftCam; 

    void Start()
    {
        MainCam.enabled = true;
        TrapCam.enabled = false;
        LiftCam.enabled = false;

        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        Player.GetComponent<AudioListener>().enabled = true;
        TrapCam.GetComponent<AudioListener>().enabled = false;
        LiftCam.GetComponent<AudioListener>().enabled = false;
    }
}
