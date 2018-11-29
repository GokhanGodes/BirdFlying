using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class Pipe : MonoBehaviour {

    Rigidbody2D PipeObject;
    SkorScript SS;

	void Start () {

        PipeObject = GetComponent<Rigidbody2D>();
        SS = GameObject.FindGameObjectWithTag("SkorDuvar").GetComponent<SkorScript>();

    }


    void Update()
    {
        PipeObject.velocity = Vector2.left * 50*Statik.PipeSpeed;
        if (SS.Skor>=30)
        {

            if (SS.MoveTime<=4 && SS.MoveTime>2)
            {
                PipeObject.velocity = new  Vector2(-250, -10) * 12 * Time.deltaTime * Statik.PipeSpeed;
            }
            if(SS.MoveTime<=2 && SS.MoveTime>0)
            {
                PipeObject.velocity = new Vector2(-250, 10) * 12 * Time.deltaTime * Statik.PipeSpeed;
            }
            if(SS.MoveTime<=0)
            {
                SS.MoveTime = 4;
            }
        }
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="SolDuvar")
        {
            Destroy();
        }
    }
}
