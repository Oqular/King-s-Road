using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class VolumeChange : MonoBehaviour {
    public Slider mySlider;

    public void ChangeVolume()
    {
        AudioListener.volume = mySlider.value;
    }
}
