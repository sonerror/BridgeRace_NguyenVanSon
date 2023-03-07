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
    [SerializeField] private Step _stepColor;

    public GetBrick _getBrick;
    public Moving _moving;

    private string TAG_BRICK = "Step";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TAG_BRICK) && _getBrick._stackBrick.Count > 0
            && other.gameObject.GetComponent<Step>().colorType != this._colorPlayer.colorType)
        {
            Debug.Log(123);
            ResourceManager._instance.ChangeColor(_numberEnums, other.gameObject);
            _getBrick.RemoveBrick();
        }
    }
}