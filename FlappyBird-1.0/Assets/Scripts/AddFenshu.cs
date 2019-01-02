using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AddFenshu : MonoBehaviour {

    public int scoreAdd;//过一个管子加的分数

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("分数加1");
            GameController.instance.Addscore(scoreAdd);
            //Debug.Log(collision.tag);
            //Debug.Log(transform.position);
        }
    }
}
