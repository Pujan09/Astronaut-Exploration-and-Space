using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeController : MonoBehaviour
{
    public Slider musicVolumeSlider; 
    public Text volumeText; 

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

       
        musicVolumeSlider.value = 0.088f;
    }

    public void SetVolume(float volume)
    {
        
        audioSource.volume = volume;
        if (volumeText != null)
        {
            volumeText.text = $"Volume: {Mathf.RoundToInt(volume * 100)}%";
        }
    }
}
