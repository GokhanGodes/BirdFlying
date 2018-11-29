using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorScript : MonoBehaviour {

    public Text SkorText;
    public GameOverScript GO;
    public int Skor = 0;
    public float MoveTime = 4;
    void Start () {
        GO = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GameOverScript>();
		
	}
	

	void Update () {

        SkorText.text = Skor.ToString();
        MoveTime -= Time.deltaTime;


    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pipe")
        {
            Skor++;
            GO.ToplamSkor = Skor;
        }
    }
}
