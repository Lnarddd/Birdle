using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SettingsMenu : MonoBehaviour
{
    [SerializeField] Slider VolumeSlider = null;
    [SerializeField] Slider BgMusicSlider = null;
    [SerializeField] Slider SFXSlider = null;
    public AudioMixer audioMixer;
    public Dropdown resolutiondrop;
    Resolution[] resolutions;

    void Start() {
        LoadVolumes();
        resolutions = Screen.resolutions;
        
        resolutiondrop.ClearOptions();
        
        List<string> opts = new List<string>();
        int CurrentRes = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string opt = resolutions[i].width + " x " + resolutions[i].height;
            opts.Add(opt);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height){
                CurrentRes = i;
            }
        }
        
        resolutiondrop.AddOptions(opts);
        resolutiondrop.value = CurrentRes;
        resolutiondrop.RefreshShownValue();
    }

    public void SetVolume (float volume )
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetMusic (float Music )
    {
        audioMixer.SetFloat("BgMusic", Music);
    }

    public void SetSFX (float SFX )
    {
        audioMixer.SetFloat("SFXAudio", SFX);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SaveVolumebutton(){
        float VolumeValue = VolumeSlider.value;
        float BgMusicValue = BgMusicSlider.value;
        float SFXValue = SFXSlider.value;
        PlayerPrefs.SetFloat("Volumeset", VolumeValue);
        PlayerPrefs.SetFloat("BGMusicset", BgMusicValue);
        PlayerPrefs.SetFloat("SFXset", SFXValue);
        LoadVolumes();
    }

    void LoadVolumes(){
        float Volume = PlayerPrefs.GetFloat("Volumeset");
        float BGM = PlayerPrefs.GetFloat("BGMusicset");
        float SFX = PlayerPrefs.GetFloat("SFXset");
        VolumeSlider.value = Volume;
        BgMusicSlider.value = BGM;
        SFXSlider.value = SFX;
    }
}
