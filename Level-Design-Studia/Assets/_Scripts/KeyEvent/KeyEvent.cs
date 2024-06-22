using UnityEngine;

public class KeyEvent : MonoBehaviour
{
    [SerializeField] private GameObject _holeFillObject;
    [SerializeField] private GameObject _eventActionPrefab;


    public void TriggerKeyEvent()
    {
        _holeFillObject.SetActive(false);
        
        Instantiate(_eventActionPrefab);
    }
}
