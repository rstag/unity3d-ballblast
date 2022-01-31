using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] KeyCode leftKey;
    [SerializeField] KeyCode rightKey;
    [SerializeField] Vector3 vector3;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(leftKey))
            GetComponent<Rigidbody>().velocity -= vector3;
        if (Input.GetKey(rightKey))
            GetComponent<Rigidbody>().velocity += vector3;
    }
}
