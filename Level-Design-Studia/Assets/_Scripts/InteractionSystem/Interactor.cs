using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
    [SerializeField] private Collider _playerCollider;
    [SerializeField] private int _maxCastDistance;
    [SerializeField] private bool _hasDoorKey;

    private bool _interactColliderHitDetect;
    private RaycastHit _interactHit;

    public bool HasDoorKey 
    {
        get
        {
            return _hasDoorKey;
        }

        set
        {
            _hasDoorKey = value;
        }
    }

    private void Start()
    {
        _hasDoorKey = false;
    }

    void Update()
    {
        CheckForInteract();
    }

    private void CheckForInteract()
    {
        //_interactColliderHitDetect = Physics.BoxCast(_playerCollider.bounds.center, transform.localScale, Vector3.forward, out _interactHit, Camera.main.transform.rotation, _maxCastDistance);
        _interactColliderHitDetect = Physics.Raycast(Camera.main.transform.position, Vector3.forward, out _interactHit, _maxCastDistance);

        if (_interactColliderHitDetect)
        {
            
            IInteractable interactable = _interactHit.transform.gameObject.GetComponent<IInteractable>();
            bool isTrigger = _interactHit.transform.gameObject.GetComponent<Collider>().isTrigger;

            if (interactable != null & isTrigger)
            {
                Debug.Log("Collided with an Interactable Object! -> " + _interactHit.transform.gameObject.name);

                if (Keyboard.current.eKey.wasPressedThisFrame)
                {
                    interactable.ExecuteInteractableAction(this);
                }
            }
            else
            {
                Debug.Log("NON-Interactable Object! -> " + _interactHit.transform.gameObject.name);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        if (_interactColliderHitDetect)
        {
            Gizmos.DrawRay(Camera.main.transform.position, transform.forward * _interactHit.distance);
            //Gizmos.DrawWireCube(_playerCollider.bounds.center + transform.forward * _interactHit.distance, transform.localScale);
        }
        else
        {
            Gizmos.DrawRay(Camera.main.transform.position, transform.forward * _maxCastDistance);
            //Gizmos.DrawWireCube(_playerCollider.bounds.center + transform.forward * _maxCastDistance, transform.localScale);
        }
    }
}
