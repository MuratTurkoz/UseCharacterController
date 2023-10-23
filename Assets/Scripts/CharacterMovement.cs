using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private CharacterController _controller;
    [SerializeField] private float _speed = 6;
    [SerializeField] private float _rotationSpeed = 6;

    private Vector3 _movement;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        //Rotate
        transform.Rotate(0,Input.GetAxis("Horizontal")*_rotationSpeed,0);
        //Move 
        _movement = transform.TransformDirection(Vector3.forward);
        float _currentSpeed = _speed * Input.GetAxis("Vertical");
        _controller.SimpleMove(_movement * _currentSpeed);

    }


}
