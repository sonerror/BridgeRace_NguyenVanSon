using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField] private GetBrick _bick;
    [SerializeField] private AnimationManager _animationManager;
    [SerializeField] private GameObject _joystick;
    private string TAG_VICTORY = "Victory";
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(TAG_VICTORY))
        {
            _bick.ClearBrick();
            _animationManager.PlayVictory();
            _joystick.SetActive(false);
        }
    }
}
