using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverDoor : MonoBehaviour
{
    [SerializeField] private Animator _doorAnimator;


    public void Execute()
    {
        Debug.Log("OPENING DOOR WITH A LEVER");
    }

}
