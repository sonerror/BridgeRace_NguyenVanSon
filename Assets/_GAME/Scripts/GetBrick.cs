using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBrick : MonoBehaviour
{
    [SerializeField]private Transform _target;
    [SerializeField] private GameObject _brick;
        

    private Stack<GameObject> _stackBrick = new Stack<GameObject>();
    private Vector3 _stack =new Vector3(0,0.5f,0);

    int _countBirck = 0;
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Brick")
        {
            
            AddBrick();
            Debug.Log(_countBirck);
            Destroy(other.gameObject);
        }
    }
    private void AddBrick()
    {
        GameObject obj = Instantiate(_brick, new Vector3(_target.position.x, _target.position.y - _countBirck * _stack.y, _target.position.z), transform.rotation);
        _stackBrick.Push(obj);
        _target.position += _stack;
        _countBirck++;
        obj.transform.SetParent(_target);
    }
}
