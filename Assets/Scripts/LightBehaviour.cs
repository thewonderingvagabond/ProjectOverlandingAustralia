using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviour : MonoBehaviour
{
    private Vector3 rotation = Vector3.zero;
    public float dayCycle= 5;

    // Update is called once per frame
    void Update()
    {
        rotation.x=dayCycle*Time.deltaTime;
        transform.Rotate(rotation,Space.World);
        
    }

}
