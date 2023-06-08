using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour {
    // Start is called before the first frame update
    public CharacterController _characterController;
    public Transform _cam;
    private Rigidbody _rb;

    public float Speed = 30.0f;
    public float TurnSpeed = 0.1f;
    private float _turnSpeedVelocity;

    private void Start() {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        float Vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(0, 0, Vertical);

        
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + _cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _turnSpeedVelocity, Speed);
            transform.rotation = Quaternion.Euler(0, angle, 0);
            Vector3 moveDir = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            _characterController.SimpleMove(moveDir.normalized * Speed * Time.deltaTime);
            
    }

    private void Gravity() {
        _rb.velocity = new Vector3(0, -0.3f, 0);
    }
    
    private void FixedUpdate() {
        Gravity();
    }
}