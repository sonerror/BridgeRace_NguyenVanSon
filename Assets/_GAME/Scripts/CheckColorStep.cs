using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColorStep : MonoBehaviour
{
    [SerializeField] private GameObject _step;
    // Hàm lấy màu của GameObject
    public Color GetGameObjectColor()
    {
        return _step.GetComponent<Renderer>().material.color;
    }
    private void Awake()
    {
        Debug.Log("Test màu" + GetGameObjectColor());
    }
}
