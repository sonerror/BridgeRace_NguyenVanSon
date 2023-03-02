using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPause : UICanvas
{
    public void Continue()
    {

    }
    public void Refresh()
    {

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
