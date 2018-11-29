using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour {

    public Transform BGTransform;
    public float Konum;
	void Start () {

	}
	
	void Update () {

        Konum = transform.position.x;
        Movement();

        if (Konum<=-265)
        {
           BGTransform.position = new Vector2((float)183.5, 0);
        }
		
	}
    public void Movement()
    {
        transform.Translate(Vector2.left * 10 * Time.smoothDeltaTime);
    }
}
