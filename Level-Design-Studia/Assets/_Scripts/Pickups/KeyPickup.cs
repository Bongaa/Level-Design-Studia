using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    [SerializeField] private GameObject _doorKeyVisual;

    private Collider _triggerCollider;

    private void Start()
    {
        _triggerCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Interactor interactor = other.GetComponent<Interactor>();
            interactor.HasDoorKey = true;

            _triggerCollider.enabled = false;
            _doorKeyVisual.SetActive(false);

            Debug.Log("YOU HAVE PICKED UP A KEY!");
        }
    }
}
