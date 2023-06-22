using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    private float _vInput;
    private float _hInput;
    private Rigidbody _rb;
    public float JumpVelocity = 5f;
    private bool _isJumping;
    public float DistanceToGround =.1f;
    public LayerMask GroundLayer;
    private Collider _col;
    public GameObject Bullet;
    public float BulletSpeed = 100f;
    private bool _isShooting;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<Collider>();
    }
    // Update is called once per frame
    void Update()
    {
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
        // this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);
        // this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);

    }
    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * _hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);

        
    }

}
