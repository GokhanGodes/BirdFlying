using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour {

    private float RealTime=5,Timer=1;
    private int Temp = 0, K = 0;
    public GameObject Pipe;
    void Start () {
		
	}
	
	void Update () {

        RealTime -= Time.deltaTime;
        Timer -= Time.deltaTime;
        if (RealTime <= 0)
        {
            Statik.PipeSpeed += (Statik.PipeSpeed / 80);
            Debug.Log(Statik.PipeSpeed);
            RealTime = 5;
        }
        if (Timer <= 0)
        {
            Instantiate(K);
            Temp = 0;
            Timer = 1;
        }
    }

    public void Instantiate(int L)
    {
        if (Temp == 0)
        {
            if (L % 2 == 0)
            {
                GameObject obj = (GameObject)Instantiate(Pipe, new Vector3(Random.Range(70f, 73f), Random.Range(-23F, -43F), 0), Quaternion.identity);
            }
            else
            {
                GameObject obj = (GameObject)Instantiate(Pipe, new Vector3(Random.Range(75f, 77f), Random.Range(-23F, -43F), 0), Quaternion.identity);
            }
            Temp++;
            K++;
        }
    }
}
