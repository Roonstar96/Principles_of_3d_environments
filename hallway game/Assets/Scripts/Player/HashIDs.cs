using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashIDs : MonoBehaviour
{
    public int dyingState;
    public int deadBool;
    public int walkState;
    public int rotateBool;
    public int shoutState;
    public int speedFloat;
    public int sneakingBool;
    public int shoutingBool;
    public int jumpingBool;

    private void Awake()
    {
        dyingState = Animator.StringToHash("Base Layer.Dying");
        deadBool = Animator.StringToHash("Dead");
        walkState = Animator.StringToHash("Walk");
        rotateBool = Animator.StringToHash("Rotate");
        shoutState = Animator.StringToHash("Shouting.Shout");
        speedFloat = Animator.StringToHash("Speed");
        sneakingBool = Animator.StringToHash("Sneaking");
        shoutingBool = Animator.StringToHash("Shouting");
        jumpingBool = Animator.StringToHash("Jumping");
    }
   
}
