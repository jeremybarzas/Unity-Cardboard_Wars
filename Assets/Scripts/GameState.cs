using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "GameState", fileName = "GameState")]
public class GameState : ScriptableSingleton<GameState>
{
    public void LoadScene(string value)
    {
        SceneManager.LoadScene(value);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public float GetTimePlayed
    {
        get { return Time.realtimeSinceStartup; }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        Debug.Log("pause");
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1f;
        Debug.Log("unpause");
    }
}