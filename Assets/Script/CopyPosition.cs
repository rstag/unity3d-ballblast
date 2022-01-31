using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField] Transform tr;

    // Update is called once per frame
    void Update()
    {
        transform.position = tr.position;
    }
}
