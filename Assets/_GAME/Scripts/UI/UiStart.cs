using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiStart : UICanvas
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
      ///  GameObject spawnedObject = Instantiate(myPrefab, spawnPoint.position, spawnPoint.rotation);
        gameObject.SetActive(false);
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
