using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class BuildBridge : MonoBehaviour
{
    [SerializeField] private GameObject _step;
    [SerializeField] private Transform _player;
    [SerializeField] private int _numberEnums;


    public GetBrick _getBrick;
    public Moving _moving;

    private string TAG_BRICK = "Step";

/*private void Bridge()
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
 }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TAG_BRICK) && _getBrick._stackBrick.Count > 0)
        {
            ResourceManager._instance.ChangeColor(_numberEnums, other.gameObject);
            _getBrick.RemoveBrick();
        }
    }
}