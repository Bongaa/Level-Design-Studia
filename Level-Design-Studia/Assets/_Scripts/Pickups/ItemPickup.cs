using StarterAssets;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] private PickupType _pickupType;
    [SerializeField] private GameObject _pickupItem;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            switch (_pickupType)
            {
                case PickupType.Weapon:
                    {
                        Transform weaponHandlerRef = other.gameObject.GetComponent<FirstPersonController>().WeaponHandler;
                        Debug.Log("WEAPON PICKUP");

                        if (weaponHandlerRef.childCount <= 0)
                        {
                            Instantiate(_pickupItem, weaponHandlerRef);
                        }
                        else
                        {
                            Destroy(weaponHandlerRef.GetChild(0).gameObject);
                            Instantiate(_pickupItem, weaponHandlerRef);
                        }
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
