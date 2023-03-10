using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField] private GetBrick _bick;
    [SerializeField] private AnimationManager _animationManager;
    [SerializeField] private GameObject _joystick;
    [SerializeField] private UINextLevel _level;

    private const string TAG_VICTORY = "Victory";

    public GameObject _buttonPause;
    public void OpenUINextLevel()
    {
        _buttonPause.SetActive(false);
        UIManager.Ins.OpenUI<UINextLevel>();
        Time.timeScale = 1f;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(TAG_VICTORY))
        {
            _bick.ClearBrick();
            _animationManager.PlayVictory();
            _joystick.SetActive(false);
            Invoke(nameof(OpenUINextLevel), 5f);
        }
    }
    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(5);
        // Thực hiện hành động sau 5 giây đợi
    }

}
