using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OgVelocity : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector3 vector3;

    // Update is called once per frame
    void FixedUpdate()
    {
            GetComponent<Rigidbody>().velocity += vector3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
