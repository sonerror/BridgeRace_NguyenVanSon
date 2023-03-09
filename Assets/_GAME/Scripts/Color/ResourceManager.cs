using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ResourceManager : MonoBehaviour
{
    public static ResourceManager _instance;
    public List<ColorManager> _color;
    protected void Awake()
    {
        ResourceManager._instance = this;
    }
    public void ChangeColor(int _number,  GameObject _gameObject)
    {
        _gameObject.GetComponent<Renderer>().material = _color[_number]._material;
    }
    public Material GetMat(ColorType colorType)
    {
        return _color[(int)colorType]._material;
    }
}