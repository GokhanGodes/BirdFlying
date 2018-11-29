using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]
public class Character : MonoBehaviour {

    Rigidbody2D Bird;
    Animator BirdAnim;
    SoundScript SS;
    private float Power=2600;
    public bool Fnished;
    public AudioClip[] Sounds;


    void Start ()
    {
        Bird = GetComponent<Rigidbody2D>();
        SS = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SoundScript>();
        Fnished = false;
        Statik.PipeSpeed = 1;
    }
	
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PowerUp();
        }
    }
    private void FixedUpdate()
    {
        if (Bird.velocity.y < 0)
        {
            Bird.velocity += Vector2.up * Physics2D.gravity.y * 1.5f * Time.deltaTime;
        }
        else if (Bird.velocity.y > 0)
        {
            Bird.velocity += Vector2.up * Physics2D.gravity.y * 2f * Time.deltaTime;
        }
    }
    public void PowerUp()
    {
        Bird.velocity = Vector2.up * Power * Time.deltaTime;

        if (PlayerPrefs.GetString("Sound")=="true")
        {
            GetComponent<AudioSource>().PlayOneShot(Sounds[0]);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Pipe")
        {
            if (PlayerPrefs.GetString("Sound") == "true")
            {
                GetComponent<AudioSource>().PlayOneShot(Sounds[1]);
            }
            Fnished = true;
        }
    }
}
