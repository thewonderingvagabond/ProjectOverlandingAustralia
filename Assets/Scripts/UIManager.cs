using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] Transform DayNightCycle; 
    //rotationSpeed is the speed of the circle, 1f means 1 degree per second, meaning 6 min for full rotation
    public float rotationSpeed = .5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //determines center of the image and rotates it with Vector3.forward
        Vector3 centerDayNightCycleImage = new Vector3(960,1370,0);
        DayNightCycle.transform.RotateAround(centerDayNightCycleImage, Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
