using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public void SingleplayerButton()
    {
        Application.LoadLevel("5.jeremytest");
    }

    public void MultiplayerButton()
    {
        Application.LoadLevel("5.jeremytest");
    }

    public void ControlsButton()
    {
        Application.LoadLevel("1.reservedscene");
    }

    public void ExitToDesktopButton()
    {
        Application.Quit();
    }
}
