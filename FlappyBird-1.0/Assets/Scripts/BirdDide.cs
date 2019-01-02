using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdDide : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="Player")
        {
            Debug.Log("小鸟Duang的一下死了");
            GameController.instance.GameOver();
            dide();
        }
    }
    public void dide()
    {
        Time.timeScale=0;
    }

}
