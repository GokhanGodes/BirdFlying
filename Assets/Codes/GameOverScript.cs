using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private Character C;
    private PauseMenuScript PM;
    public GameObject GameOver;
    public Text Skor;
    public AudioSource GameMusic;
    public int ToplamSkor,HighScore,LastScore,NextScore;
    private SoundScript SS;
    private AdManager AD;

    void Start()
    {
        C = GameObject.FindGameObjectWithTag("Bird").GetComponent<Character>();
        PM = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<PauseMenuScript>();
        SS = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SoundScript>();
        AD = GameObject.FindGameObjectWithTag("Admob").GetComponent<AdManager>();
        GameOver.SetActive(false);
        Time.timeScale = 1;
        PM.PlayButton.SetActive(true);
        LastScore = PlayerPrefs.GetInt("LastScore");
        HighScore = PlayerPrefs.GetInt("HighScore");
        GameMusic.Play();
        if (PlayerPrefs.GetString("Sound") == "false")
        {
            GameMusic.Stop();
        }



    }

    void Update()
    {

        if (C.Fnished)
        {
            AD.ShowVideo();
            GameOver.SetActive(true);
            Time.timeScale = 0;
            Skor.text ="SCORE\n" + ToplamSkor.ToString();
            NextScore = ToplamSkor;
            LastScore = NextScore;
            if (NextScore>HighScore)
            {
                HighScore =NextScore;
                PlayerPrefs.SetInt("HighScore", HighScore);
            }
            PlayerPrefs.SetInt("LastScore", LastScore);
            PlayerPrefs.SetInt("HighScore", HighScore);
            PM.PlayButton.SetActive(false);
            NextScore = 0;
            GameMusic.Stop();
        }

    }
}
