using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable] public class ColorManager
{
    [SerializeField] public ColorType _resourceName;
    [SerializeField] public Material _material;
}

public enum ColorType
{
    Red = 0,
    Green = 1,
    Blue = 2,
    Yellow = 3,
}