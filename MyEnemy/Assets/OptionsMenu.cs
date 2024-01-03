using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer mixer;
    Resolution[] resolutions;
    public Slider slider;
    public Toggle toggle;
    private float startVolume;
    public TMP_Dropdown dropdown;
    private void Start()
    {
        
        startVolume = PlayerPrefs.GetFloat("volume");
        StartVolume();
        resolutions = Screen.resolutions;

        dropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height) 
            {
                currentResIndex = i;
            }
        }

        dropdown.AddOptions(options);
        dropdown.value = currentResIndex;
        dropdown.RefreshShownValue();
        
    }

    public void Update()
    {

    }
    public void SetVolume(float volume)
    {
        mixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("volume", volume);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width , resolution.height , Screen.fullScreen);
    }
    public void StartVolume()
    {
        mixer.SetFloat("volume", startVolume);
        PlayerPrefs.SetFloat("volume", startVolume);
        slider.value = startVolume;
    }

    public void E()
    {
        print("e");
    }

    //scrapped code
    public void SetMobile(bool isMobile)
    {
        if (isMobile == false)
        {
            SetFalse();
        }
        else if (isMobile == true)
        {
            SetTrue();
        }
    }

    public void SetTrue()
    {
        print("mobile = 1");
        PlayerPrefs.SetInt("mobile", 1);
    }
    public void SetFalse()
    {
        print("mobile = 0");
        PlayerPrefs.SetInt("mobile", 0);
    }
}
