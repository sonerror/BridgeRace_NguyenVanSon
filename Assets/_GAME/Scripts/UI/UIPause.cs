using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIPause : UICanvas
{
    public void Continue()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        UIManager.Ins.OpenUI<ButtonPause>();
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }
    public void QuitGame()
    {
        Debug.Log("exit");
        #if UNITY_EDITOR
           UnityEditor.EditorApplication.isPlaying = false;
        #endif
        #if UNITY_STANDALONE
            Application.Quit();
        #endif
    }
}
