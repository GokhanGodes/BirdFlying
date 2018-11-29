using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundScript : MonoBehaviour {

    public Image SoundOn,SoundOff;
    void Start()
    {
        //PlayerPrefs.DeleteKey("Sound");
        if (!PlayerPrefs.HasKey("Sound"))
        {
            PlayerPrefs.SetString("Sound", "true");
        }
    }
	
	void Update () {

    }
    public void ClickSound()
    {
        if(PlayerPrefs.GetString("Sound")=="true")
        {
            SoundOn.enabled = false;
            SoundOff.enabled = true;
            PlayerPrefs.SetString("Sound", "false");
        }
        else
        {
            SoundOn.enabled = true;
            SoundOff.enabled = false;
            PlayerPrefs.SetString("Sound", "true");
        }

    }
}
