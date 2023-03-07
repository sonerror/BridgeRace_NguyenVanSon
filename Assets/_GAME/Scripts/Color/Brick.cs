using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] Renderer renderer;
    public ColorType colorType;
    public int _number;
    private void Start()
    {
        Create();
    }
    protected virtual void Create()
    {
        _number = Random.Range(0, 4);
        ResourceManager._instance.ChangeColor(_number, transform.gameObject);
    }
    public void ChangeColor(ColorType colorType)
    {
        this.colorType = colorType;
        renderer.material = ResourceManager._instance.GetMat(colorType);
    }
}
