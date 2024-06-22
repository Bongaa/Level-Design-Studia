using UnityEngine;

public class LeverDoor : MonoBehaviour
{
    [SerializeField] private Animator _doorAnimator;


    public void Execute()
    {
        OpenDoor();
    }

    private void OpenDoor()
    {
        Debug.Log("OPENING DOOR WITH A LEVER");
        _doorAnimator.SetBool("OpenDoor", true);
    }

}
