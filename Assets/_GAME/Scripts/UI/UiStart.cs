using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiStart : UICanvas
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void QuitGame()
    {


        #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
        #else
         Application.Quit();
        #endif
    }
}
