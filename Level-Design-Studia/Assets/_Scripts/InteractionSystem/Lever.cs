using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] private bool _isPulled;
    [SerializeField] private GameObject _connectedDiode;

    private Material _diodeMaterial;

    private void Start()
    {
        if (_connectedDiode != null)
        {
            _diodeMaterial = _connectedDiode.GetComponentInChildren<MeshRenderer>().material;
        }
    }

    public bool IsPulled
    {
        get
        {
            return _isPulled;
        }

        set
        {
            _isPulled = value;
            
            if (_connectedDiode != null)
            {
                _diodeMaterial.SetColor("_Color", Color.green);
                _diodeMaterial.SetColor("_EmissionColor", Color.green);
            }
        }
    }
}
