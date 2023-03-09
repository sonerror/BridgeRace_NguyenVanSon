using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEditor.UIElements;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Moving : MonoBehaviour
{
    [SerializeField] private FloatingJoystick _joystick;
    [SerializeField] private AnimationManager _animationManager;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;

    private Rigidbody _rigidbody;
    private Vector3 _moveVetor;

    private void Awake()
    {
        _rigidbody= GetComponent<Rigidbody>();

    }
    private void Update()
    {
        Move();
    }
    public void Move()
    {
        _moveVetor = Vector3.zero;
        _moveVetor.x = _joystick.Horizontal * _moveSpeed * Time.deltaTime;
        _moveVetor.z = _joystick.Vertical   * _moveSpeed * Time.deltaTime;
        if(_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            Vector3 direction = Vector3.RotateTowards(transform.forward, _moveVetor, _rotateSpeed * Time.deltaTime,0.0f);
            transform.rotation= Quaternion.LookRotation(direction);
            _animationManager.PlayRun();
        }
        else if(_joystick.Horizontal == 0 && _joystick.Vertical == 0)
        {
            _animationManager.PlayIdle();
        }
        //_rigidbody.MovePosition(_rigidbody.position + _moveVetor);
        _rigidbody.velocity = _moveVetor.normalized * _moveSpeed  + _rigidbody.velocity.y * Vector3.up;
    }
     public void stopMoving()
    {
        _moveSpeed = 0.1f;
    }
    public void NotStop()
    {
        if(_rigidbody.velocity.y < 0)
        {
            _moveSpeed = 10f;
        }
    }
}
