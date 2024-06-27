using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCameraLookAt : MonoBehaviour
{
    [SerializeField] private TextMeshPro _text;


    void Update()
    {
        _text.transform.LookAt(Camera.main.transform);
    }
}
