using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildBridge : MonoBehaviour
{
    [SerializeField] private GameObject _step;
    [SerializeField] private Transform _player;
    private GetBrick _getBrick;
    private int _count = 0;

    private void Update()
    {
       Bridge();
    }
    private void Bridge()
    {
        RaycastHit hit;
        Debug.DrawLine(_player.position + new Vector3(0, 0.5f, 1f), _player.position + new Vector3(0, 0, 0.25f) + Vector3.down * 50f, color: Color.red);
        //Debug.Log(isHit);
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 50f))
        {
            if (hit.collider.tag == "Step")
            {
                _step.GetComponent<Renderer>().material.color = Color.blue;
                //_step.GetComponent<Renderer>().material = ResourceManager._instance._color[2]._material;
                _getBrick.RemoveBrick();
            }
        }
    }
    /* private void OnTriggerEnter(Collider other)
     {
         if(other.tag == "Step")
         {
             gameObject.GetComponent<Renderer>().material.color = Color.blue;
             //_getBrick.RemoveBrick();
             Debug.Log("Step");
         }
     }*/
}