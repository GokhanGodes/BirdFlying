using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour {

    public GameObject PlayButton, PauseMenu, PauseButton;
    public bool IsPaused;
    void Start () {

        PauseMenu.SetActive(false);
        IsPaused = false;
        Time.timeScale = 1;
    }

	void Update () {

        //if(Input.GetKeyDown(KeyCode.Escape))
        //{
        //    if(IsPaused==false)
        //    {
        //        Paused();
        //    }
        //    else
        //    {
        //        DontPaused();
        //    }
        //}
		
	}
    public void Paused()
    {
        IsPaused = true;
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
        PlayButton.SetActive(false);

    }
    public void DontPaused()
    {
        IsPaused = false;
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        PlayButton.SetActive(true);
    }
    public void OnResume()
    {
        DontPaused();
    }
    public void OnRestart()
    {
        SceneManager.LoadSceneAsync("GameScene");
    }
    public void OnMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
    public void OnQuit()
    {
        Debug.Log("Çıkış Yapıldı");
        Application.Quit();
    }
    public void OnPause()
    {
        if(IsPaused)
        {
            DontPaused();
        }
        else
        {
            Paused();
        }
    }
}
