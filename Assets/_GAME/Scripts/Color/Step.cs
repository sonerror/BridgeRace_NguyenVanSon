using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step : MonoBehaviour
{
    public ColorType colorType;
    [SerializeField] private Brick _brick;
    public MeshRenderer ren;
    public ColorType currentColor = ColorType.Transparent;
    private void Awake()
    {
        _brick.ChangeColor(ColorType.Transparent);
    }
    public void BuildStair(ColorType color)
    {
        ren.material = ResourceManager._instance.GetMat(color);
        currentColor = color;
    }
    internal void ChangeColor(ColorType colorType)
    {
        Material newMaterial = ResourceManager._instance.GetMat(colorType);
        ren.material = newMaterial;
        this.colorType = colorType; 
    }
}
