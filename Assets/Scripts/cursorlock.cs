using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorlock : MonoBehaviour
{
    CursorLockMode wantedMode;
    public bool toggle;

    // Apply requested cursor state
    void SetCursorState()
    {
        Cursor.lockState = wantedMode;
        // Hide cursor when locking
        Cursor.visible = (CursorLockMode.Locked != wantedMode);
    }
   
    void OnGUI()
    {
        GUILayout.BeginVertical();
        
        if (Input.GetKeyDown(KeyCode.Escape))
            Cursor.lockState = wantedMode = CursorLockMode.None;

        GUILayout.EndVertical();

        SetCursorState();
    }

    private void Start()
    {
        toggle = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (toggle)
            {
                Cursor.lockState = wantedMode = CursorLockMode.Locked;
                toggle = false;
            }
            else
            {
                Cursor.lockState = wantedMode = CursorLockMode.None;
                toggle = true;
            }
        }
    }
}
