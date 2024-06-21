using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private LeverDoor _doorObject;

    public void ExecuteInteractableAction()
    {
        PlayInteractableAnim();

        Debug.Log("LEVER INTERACTION");
        _doorObject.Execute();
    }

    public void PlayInteractableAnim()
    {
        Debug.Log("LEVER ANIMATION PLAYING");
    }
}
