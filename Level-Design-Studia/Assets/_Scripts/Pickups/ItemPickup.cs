using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] private PickupType _pickupType;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (_pickupType)
            {
                case PickupType.Weapon:
                    {
                        Debug.Log("WEAPON PICKUP");
                    }
                    break;
                case PickupType.Consumable:
                    {
                        Debug.Log("CONSUMABLE PICKUP");
                    }
                    break;
                case PickupType.Armor:
                    {
                        Debug.Log("ARMOR PICKUP");
                    }
                    break;
                default:
                    {
                        Debug.LogWarning("MISSING PICKUP TYPE");
                    }
                    break;
            }
            Destroy(gameObject);
        }
    }
}
