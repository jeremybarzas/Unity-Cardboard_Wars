using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControlBehaviour : MonoBehaviour
{
    public AudioClip m_EngineDriving;
    public AudioClip m_EngineIdling;
    public AudioSource m_MovementAudio;

    private float m_MovementInputValue;
    private float m_OriginalPitch;
    public float m_PitchRange = 0.2f;
    private float m_TurnInputValue;
    public float speed = 5;

    private void CharacterMove()
    {
        var y = Input.GetAxis("HorizontalKeyboard") * Time.deltaTime * speed * 15;
        m_TurnInputValue = y;
        var z = Input.GetAxis("VerticalKeyboard") * Time.deltaTime * speed;
        m_MovementInputValue = z;

        transform.Rotate(0, y, 0);
        transform.Translate(0, 0, z);
    }

    private void OnEnable()
    {
        // Also reset the input values.
        m_MovementInputValue = 0f;
        m_TurnInputValue = 0f;
    }

    private void Start()
    {
        m_OriginalPitch = m_MovementAudio.pitch;
    }

    private void Update()
    {
        CharacterMove();
        EngineAudio();
    }

    private void EngineAudio()
    {
        // If there is no input (the tank is stationary)...
        if (Mathf.Abs(m_MovementInputValue) < 0.01f && Mathf.Abs(m_TurnInputValue) < 0.1f)
        {
            // ... and if the audio source is currently playing the driving clip...
            if (m_MovementAudio.clip == m_EngineDriving)
            {
                // ... change the clip to idling and play it.
                m_MovementAudio.clip = m_EngineIdling;
                m_MovementAudio.pitch = Random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange);
                m_MovementAudio.Play();
            }
        }
        else
        {
            // Otherwise if the tank is moving and if the idling clip is currently playing...
            if (m_MovementAudio.clip == m_EngineIdling)
            {
                // ... change the clip to driving and play.
                m_MovementAudio.clip = m_EngineDriving;
                m_MovementAudio.pitch = Random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange);
                m_MovementAudio.Play();
            }
        }
    }
}
