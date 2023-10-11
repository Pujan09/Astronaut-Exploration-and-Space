using UnityEngine;

public class MusicToggle : MonoBehaviour
{
    public AudioSource audioSource;
    private bool isAudioPlaying = true;

    private void Start()
    {
        
        audioSource.Play();
    }

    public void ToggleAudio()
    {
        if (isAudioPlaying)
        {
            audioSource.Pause(); 
        }
        else
        {
            audioSource.Play(); 
        }

        isAudioPlaying = !isAudioPlaying; 
    }
}

