    using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;


public class BuildBridge : MonoBehaviour
{
    [SerializeField] private GameObject _step;
    [SerializeField] private Transform _player;
    [SerializeField] private int _numberEnums;
    [SerializeField] private ColorPlayer _colorPlayer;
    [SerializeField] private Transform _ponitRayCast;

    public GetBrick _getBrick;
    public Moving _moving;

    private string TAG_STEP = "Step";
    [SerializeField] private bool _checkBridge;


    private void Update()
    {
        CheckStep();
        if (_checkBridge == false)
        {
            _moving.stopMoving();
        }
        else
        {
            _moving.NotStop();
        }

    }
    private bool CheckStep()//kiểm tra xem có được đi tiếp không
    {
        RaycastHit hit;
        Debug.DrawRay(_ponitRayCast.position, Vector3.down * 50f, color: Color.red);
        if (Physics.Raycast(_ponitRayCast.position,Vector3.down, out hit, 50f))
        {
            if (hit.collider.CompareTag(TAG_STEP))
            {
                Step step = hit.transform.GetComponent<Step>();
                if (_getBrick._listStack.Count <= 0)
                {
                    if (step.colorType != _colorPlayer._colorType)
                    {
                        return _checkBridge = false;
                    }
                }
            }
        }
         return _checkBridge = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TAG_STEP))
        {
            if (_getBrick._stackBrick.Count > 0)
            {
                Step step = other.GetComponent<Step>();
                if (step != null) 
                {
                    if (step.colorType != _colorPlayer._colorType)
                    {
                        step.ChangeColor(_colorPlayer._colorType);
                        _getBrick.RemoveBrick();
                    }
                }
            }
        }
    }
}