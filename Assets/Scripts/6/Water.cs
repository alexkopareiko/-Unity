using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public float Density = 100;
    private void OnTriggerStay(Collider other)
    {
        Rigidbody _otherRb = other.gameObject.GetComponent<Rigidbody>();
        _otherRb.AddForce((Vector3.up * Density * _otherRb.mass), ForceMode.Force);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
