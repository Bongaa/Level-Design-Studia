using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] private bool _isPulled;

    public bool IsPulled
    {
        get
        {
            return _isPulled;
        }

        set
        {
            _isPulled = value;
        }
    }
}
