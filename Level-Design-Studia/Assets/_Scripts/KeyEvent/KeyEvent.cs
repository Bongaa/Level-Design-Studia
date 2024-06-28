using UnityEngine;

public class KeyEvent : MonoBehaviour
{
    [SerializeField] private GameObject _holeFillObject;
    [SerializeField] private GameObject _eventActionPrefab;
    [SerializeField] private Animator _gridAnimator;


    public void TriggerKeyEvent()
    {
        _holeFillObject.SetActive(false);

        _gridAnimator.SetBool("IsKeyPickedUp", true);

        Instantiate(_eventActionPrefab);
    }
}
