using UnityEngine;

public class LeverInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private Lever _lever;
    [SerializeField] private LeverDoor _doorObject;
    [SerializeField] private bool _isLockedWithKey;

    public void ExecuteInteractableAction(Interactor interactor)
    {
        _lever.IsPulled = true;

        if (_isLockedWithKey && interactor.HasDoorKey)
        {
            Debug.Log("LOCKED LEVER INTERACTION");
            _doorObject.Execute();
        }
        else if (!_isLockedWithKey)
        {
            Debug.Log("LEVER INTERACTION");
            _doorObject.Execute();
        }
        else
        {
            Debug.Log("FIND THE KEY!");
        }
    }

    public void PlayInteractableAnim()
    {
        Debug.Log("LEVER ANIMATION PLAYING");
    }
}
