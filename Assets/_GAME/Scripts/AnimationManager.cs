using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] Animator _animator;
    private string _currentAnimName;

    private string ANIM_IDLE = "Idle";
    private string ANIM_RUN = "Run";
    private string ANIM_WIN = "Victory";
    private string ANIM_EIDLE = "EIdle";
    private string ANIM_ERUN = "ERun";

    private void Awake()
    {
        _animator = gameObject.GetComponent<Animator>();
    }
    public void PlayIdle()
    {
        ChangeAnim(ANIM_IDLE);
    }
    public void PlayRun()
    {
        ChangeAnim(ANIM_RUN);
    }
    public void PlayVictory()
    {
        ChangeAnim(ANIM_WIN);
    }
    public void PlayEIdle()
    {
        ChangeAnim(ANIM_EIDLE);
    }
    public void EPlayRun()
    {
        ChangeAnim(ANIM_ERUN);
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
