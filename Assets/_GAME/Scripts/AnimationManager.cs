using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] Animator _animator;
    private string _currentAnimName;

    private void Awake()
    {
        _animator = gameObject.GetComponent<Animator>();
    }
    public void PlayIdle()
    {
        ChangeAnim("Idle");
    }
    public void PlayRun()
    {
        ChangeAnim("Run");
    }
    public void PlayVictory()
    {
        ChangeAnim("Victory");
    }

    public void ChangeAnim(string animName)
    {
        if (_currentAnimName != animName)
        {
            _animator.ResetTrigger(animName);
            _currentAnimName = animName;
            _animator.SetTrigger(_currentAnimName);
        }
    }
}
