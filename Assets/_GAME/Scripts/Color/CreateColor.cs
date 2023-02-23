using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateColor : MonoBehaviour
{
    public int _number;
    private void Start()
    {
        Create();
    }
    protected virtual void Create()
    {
        _number = Random.Range(0, 6);
       // Debug.Log(_number);
        ResourceManager._instance.ChangeColor(_number, transform.gameObject);
    }
}
