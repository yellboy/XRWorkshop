using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDogMovement : MonoBehaviour
{
    private const float velocity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger)) {
            transform.Translate(Vector3.left * velocity * Time.deltaTime, Space.World);
        } 
        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger)) {
            transform.Translate(Vector3.right * velocity * Time.deltaTime, Space.World);
        }
    }
}
