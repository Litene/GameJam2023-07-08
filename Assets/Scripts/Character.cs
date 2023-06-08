using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Cinemachine;
using UnityEngine;

public class Character : MonoBehaviour {
    private float _size = 2;
    private Vector3 GrowthMulti = new Vector3(1, 1, 1);
    private float CoolDown = 3.0f;
    private float CoolTimer = 0;
    private CharacterMovement _movement;

    public float Size {
        get { return _size; }
        set {
            _size = value;
            Grow(_size);
            if (_size <= 0) {
                Death();
            }
        }
    }

    private void Grow(float size) {
        if (CoolTimer > CoolDown) {
            CoolTimer = 0;
            _movement.Speed = (10 - size) * 500;
        }
    }

    // Start is called before the first frame update
    void Start() {
        transform.localScale = GrowthMulti * _size;
        _movement = GetComponent<CharacterMovement>();
    }

    private void Death() {
        Debug.Log("Dead");
        Application.Quit();
    }

    // Update is called once per frame
    void Update() {
        CoolTimer += Time.deltaTime;
    }
}