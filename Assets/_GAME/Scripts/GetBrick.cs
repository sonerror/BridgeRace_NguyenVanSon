using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBrick : MonoBehaviour
{
    [SerializeField]private Transform _target;
    [SerializeField] private GameObject _brick;
    [SerializeField] private int _colerPlayer;
    

    private Stack<GameObject> _stackBrick = new Stack<GameObject>();
    private Vector3 _stack =new Vector3(0,0.25f,0);

    int _countBirck = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Brick")
        {
            if (other.gameObject.GetComponent<CreateColor>()._number == _colerPlayer)
            {
                AddBrick();
                Debug.Log(_countBirck);
                Destroy(other.gameObject);
            }
        }
        if(other.tag == "Victory")
        {
            ClearBrick();
            //_animationManager.PlayVictory();
        }
    }
    private void AddBrick()
    {
        GameObject obj = Instantiate(_brick, new Vector3(_target.position.x, _target.position.y - _countBirck * _stack.y, _target.position.z), transform.rotation);
        _stackBrick.Push(obj);
        _target.position += _stack;
        _countBirck++;
        obj.transform.SetParent(_target);
        obj.GetComponent<Renderer>().material = ResourceManager._instance._color[1]._material;
    }
    public void RemoveBrick()
    {
        transform.position -= _stack;
        Destroy(_stackBrick.Pop());
    }
    private void ClearBrick()
    {
        for(int i = 1; i < _countBirck; i++)
        {
            RemoveBrick();
        }
    }
}