using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBrick : MonoBehaviour
{
    [SerializeField]private Transform _target;
    [SerializeField] private GameObject _brick;
    [SerializeField] private int _numberEnums;
    
    public Stack<GameObject> _stackBrick = new Stack<GameObject>();
    private Vector3 _stack =new Vector3(0,0.25f,0);
    public List<GameObject> _listStack = new List<GameObject>();

    private string TAG_BRICK = "Brick";
    private string TAG_VICTORY = "Victory";

    int _count = 0;

    private void OnTriggerEnter(Collider other)
    {
        Brick brick = other.GetComponent<Brick>();
        if (other.CompareTag(TAG_BRICK))
        {
            if (brick._number == _numberEnums)
            {
                AddBrick();
                _listStack.Add(other.gameObject);
                other.gameObject.SetActive(false);
            }
        }
        if(other.CompareTag(TAG_VICTORY))
        {
            RemoveBrick();
        }
    }
    private void AddBrick()
    {
        GameObject obj = Instantiate(_brick, new Vector3(_target.position.x, _target.position.y - _count * _stack.y, _target.position.z), transform.rotation);
        _stackBrick.Push(obj);
        _target.position += _stack;
        _count++;
        obj.transform.SetParent(_target);
        obj.GetComponent<Renderer>().material = ResourceManager._instance._color[_numberEnums]._material;
    }
    public void RemoveBrick()
    {
        _count--;
        _target.position -= _stack;
        _stackBrick.Pop();
        Destroy(_target.GetChild(_count).gameObject);
        _listStack[_listStack.Count - 1].SetActive(true);
        _listStack.RemoveAt(_listStack.Count - 1);
    }
    public void ClearBrick()
    {
        for(int i = 1; i <= _count; i++)
        {
            RemoveBrick();
        }
    }
}