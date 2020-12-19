using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    [SerializeField] private Vector3 rotate = Vector3.one;
    
    void Update()
    {
        transform.eulerAngles += rotate * Time.deltaTime;
    }
}
