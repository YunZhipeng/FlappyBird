using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
    //void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.tag == "Player")
    //    {
    //        Debug.Log("分数加1");
    //        //Debug.Log(collision.tag);
    //        //Debug.Log(transform.position);
    //    }
    //}

}
