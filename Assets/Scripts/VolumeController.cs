using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public MusicController musicController;
    public void SetVolume(float value)
    {
        sliderValue = value;
        musicController.GetComponent<AudioSource>().volume = sliderValue;
    }
}
