using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColorStep : MonoBehaviour
{
    // Hàm lấy màu của GameObject
    public Color GetGameObjectColor()
    {
        return gameObject.GetComponent<Renderer>().material.color;
    }
}
