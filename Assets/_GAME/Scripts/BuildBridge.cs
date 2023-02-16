using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildBridge : MonoBehaviour
{
    // [SerializeField] private GameObject _step;
    [SerializeField] private Transform _player;
    [SerializeField] private LayerMask _BRIDGE_LAYER;

    private void Update()
    {
        Bridge();
    }
    private void Bridge()
    {
        /*        RaycastHit hit;
                //Ray ray = new Ray(_player.position + new Vector3(0, 0.5f, 0.25f), Vector3.down);
                Debug.DrawLine(_player.position + new Vector3(0, 0.5f, 0.25f), _player.position + new Vector3(0,0,0.25f) + Vector3.down * 50f ,color:Color.red ); 
               // bool isHit = Physics.Raycast(ray, out hit,50f);
               if(Physics.Raycast(transform.position, Vector3.down, out hit, 100f))
                    {

                }*/
        //Debug.DrawLine(_player.position + new Vector3(0, 0.5f, 0.25f), _player.position + new Vector3(0, 0, 0.25f) + Vector3.down * 50f, color: Color.red);

        Ray ray = new Ray(_player.position + new Vector3(0, 0.5f, 0.25f), Vector3.down);
        RaycastHit hit;
        Debug.DrawLine(_player.position + new Vector3(0, 0.5f, 0.5f), _player.position + new Vector3(0, 0, 0.25f) + Vector3.down * 50f, color: Color.red);
        bool isHit = Physics.Raycast(ray, out hit, 50f, _BRIDGE_LAYER);
        Debug.Log(isHit);
        if (isHit)
        {
            if (hit.collider != null && hit.collider.tag == "Stair")
            {
                Debug.Log(hit.point);
            }
        }
    }
}
