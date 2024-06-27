using System.Collections.Generic;
using UnityEngine;

public class LeverDoor : MonoBehaviour
{
    [SerializeField] private Animator _doorAnimator;
    [SerializeField] private List<Lever> _connectedLevers;


    public void Execute()
    {
        OpenDoor();
    }

    private void OpenDoor()
    {

        foreach (var lever in _connectedLevers)
        {
            if (!lever.IsPulled)
            {
                Debug.Log($"LEVER {lever.name} NOT PULLED");
                return;
            }
        }

        Debug.Log("OPENING DOOR WITH A LEVER");
        _doorAnimator.SetBool("OpenDoor", true);
    }

}
