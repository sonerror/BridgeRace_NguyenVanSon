using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class BuildBridge : MonoBehaviour
{
    [SerializeField] private GameObject _step;
    [SerializeField] private Transform _player;
    public GetBrick _getBrick;
    public Moving _moving;


    private void Update()
    {
        Bridge();
    }
    private void Bridge()
    {
        RaycastHit hit;
        Debug.DrawLine(_player.position + new Vector3(0, 0.5f, 0.5f), _player.position + new Vector3(0, 0, 0.25f) + Vector3.down * 50f, color: Color.red);
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 50f))
        {
            if (hit.collider.tag == "Step")
            {

                //_moving.stopMoving();
                //Debug.Log("test");
                //Debug.Log(_getBrick == null);
                _getBrick.RemoveBrick();
               // ResourceManager._instance.ChangeColor(1, hit.transform.gameObject);
                Debug.Log(hit.transform.gameObject);

            }
            //_moving.Move();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Color col = other.gameObject.GetComponent<Renderer>().material.color;
        Color color = new Color(0.000f, 0.173f, 1.000f, 1.000f);
        Debug.Log(color);

        if (other.tag == "Step" && _getBrick._stackBrick.Count > 0 && col != color)
        {
            ResourceManager._instance.ChangeColor(1, other.gameObject);
            _getBrick.RemoveBrick();
        }
    }
}