using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 200f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            m_Rigidbody.AddForce(Vector3.up * m_Thrust);
        }
    }
}
