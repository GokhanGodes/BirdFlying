using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartingScript : MonoBehaviour {

    public Image SpeakerOn, SpeakerOff;
    public Text LastScore;
    public Text HighScore;
	void Start () {
        if(PlayerPrefs.HasKey("Sound"))
        {
            if(PlayerPrefs.GetString("Sound")=="true")
            {
                SpeakerOn.enabled = true;
                SpeakerOff.enabled = false;
            }
            else
            {
                SpeakerOn.enabled = false;
                SpeakerOff.enabled = true;
            }
        }
        else if (!PlayerPrefs.HasKey("Sound"))
        {
            PlayerPrefs.SetString("Sound", "true");
            SpeakerOn.enabled = true;
            SpeakerOff.enabled = false;

        }

    }
	void Update () {

        LastScore.text = "LAST SCORE\n"+ PlayerPrefs.GetInt("LastScore").ToString();
        HighScore.text = "HIGH SCORE\n" + PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void OnPlay()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void OnOptions()
    {
        PlayerPrefs.DeleteAll();
        //SceneManager.LoadScene("OptionsScene");
    }
    public void OnQuit()
    {
        Application.Quit();
    }

}
