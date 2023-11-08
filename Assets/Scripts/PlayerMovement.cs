using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _speed;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(0f, 0f, 1f * _speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(0f, 0f, -1f * _speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(1f * _speed, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(-1f * _speed, 0f, 0f);
        }
    }

}