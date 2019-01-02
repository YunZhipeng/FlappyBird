using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    public float upJump=300;//给bird一个300的力
    private Rigidbody2D rig2D;
    private Animation anim;
    
    private void Awake()
    {
        rig2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animation>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))
        {
            Fly();
        }
	}
    public void Fly()
    {
        rig2D.velocity = Vector2.zero;
        Vector2 upForce = Vector2.up * upJump;
        rig2D.AddForce(upForce);
    }
    
   
}
