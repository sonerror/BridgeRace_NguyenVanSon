using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// DG.Tweening;
public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    Transform Transform { get => transform; }
    [SerializeField] private Vector3 offset;
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
    /*[SerializeField] private Transform _play;
    [SerializeField] private float _speed;
    private Transform _camera;
    private Vector3 _offset;

    private void Awake()
    {
        _camera = this.transform;
        _offset = _camera.position - _play.position;
    }
    private void Update()
    {
        Follow();
    }
    private void Follow()
    {
        _camera.DOMoveX(_play.position.x + _offset.x, _speed * Time.deltaTime);
        _camera.DOMoveX(_play.position.z + _offset.z, _speed * Time.deltaTime);
    }*/

}

