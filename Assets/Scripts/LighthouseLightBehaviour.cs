using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighthouseLightBehaviour : MonoBehaviour
{
    public int rotationSpeed = 10;
    private Transform itemTransform;
    // Start is called before the first frame update
    void Start()
    {
        itemTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        itemTransform.Rotate(0,rotationSpeed*Time.deltaTime,0);
    }
}
