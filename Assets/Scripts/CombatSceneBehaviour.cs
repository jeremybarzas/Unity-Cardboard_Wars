using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSceneBehaviour : MonoBehaviour
{
    public TankBehaviour player;
    public Canvas pauseMenu;
    public Canvas controls;
    public Canvas gameover;
    private bool paused;

    public void onResumeClicked()
    {
        pauseMenu.enabled = false;
        GameState.Instance.UnpauseGame();
        paused = false;
    }

    public void onControlsClicked()
    {
        pauseMenu.enabled = false;
        controls.enabled = true;
    }

    public void onBackClicked()
    {
        controls.enabled = false;
        pauseMenu.enabled = true;
    }

    public void onMainMenuClicked(string value)
    {
        GameState.Instance.LoadScene(value);
    }

    public void onExitClicked()
    {
        GameState.Instance.QuitGame();
    }

    public void onRematchClicked()
    {
        GameState.Instance.RestartScene();         
    }

    public void onGameOver(string n)
    {        
        gameover.enabled = true;
        GameState.Instance.PauseGame();
    }

    private void Awake()
    {
        TankBehaviour.onTankDeath.AddListener(onGameOver);
    }

    void Start()
    {
        GameState.Instance.UnpauseGame();
        paused = false;
        pauseMenu.enabled = false;
        controls.enabled = false;
        gameover.enabled = false;
    }

    void Update()
    {
        if (!paused)
        {
            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("Submit"))
            {
                paused = true;
                pauseMenu.enabled = true;
                GameState.Instance.PauseGame();
            }
        }
    }
}
