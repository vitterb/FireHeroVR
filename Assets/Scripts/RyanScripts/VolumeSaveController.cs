using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeSaveController : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private Text volumeTextUITMPro = null;

    public void VolumeSlider(float volume)
    {
        volumeTextUITMPro.text = volume.ToString("0.0");
    }
}
