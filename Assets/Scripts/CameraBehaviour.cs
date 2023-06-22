using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    // public float CamOffSetX = 0f;
    // public float CamOffSetY = 2f;
    // public float CamOffSetZ = -3f; 
    // private Vector3 CamOffset;
    
    // private Transform _target;

    // void Awake()
    // {
    //     Vector3 CamOffset = new Vector3(CamOffSetX,CamOffSetY,CamOffSetZ);
    // }
    // // Start is called before the first frame update
    // void Start()
    // {
    //     _target = GameObject.Find("Car").transform;
    // }

    // // Update is called once per frame
    // void LateUpdate()
    // {
    //     this.transform.position = _target.TransformPoint(CamOffset);
    //     this.transform.LookAt(_target);
    // }
    public Transform Car;
    public float maxDistance = 10;
    public float moveSpeed = 20;
    public float updateSpeed = 10;
    [Range(0,10)]
    public float currentDistance = 5;
    private string moveAxis = "Mouse ScrollWheel";
    private GameObject ahead;
    private MeshRenderer _renderer;
    public float hideDistance= 1.5f;

    void Start()
    {
        ahead = new GameObject("ahead");
        _renderer = Car.gameObject.GetComponent<MeshRenderer>();
    }
    void LateUpdate()
    {
        ahead.transform.position = Car.position + Car.forward *(maxDistance * 0.25f);
        currentDistance += Input.GetAxisRaw(moveAxis) * moveSpeed * Time.deltaTime;
        currentDistance = Mathf.Clamp(currentDistance,0,maxDistance);
        transform.position = Vector3.MoveTowards(transform.position, Car.position + Vector3.up *currentDistance - Car.forward *(currentDistance + maxDistance * 0.5f), updateSpeed * Time.deltaTime); 
        transform.LookAt(ahead.transform);
        _renderer.enabled = (currentDistance > hideDistance);
    }
}
