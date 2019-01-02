using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround : MonoBehaviour
{
    public static MovingGround instance;
    
    public float speed;//屏幕移动速度
    private Rigidbody2D rb2D;

    void Awake()
    {
        instance = this;
        
    }

    // Use this for initialization
    void Start () {
        rb2D = GetComponent<Rigidbody2D>();//获取Rigidbody2D组件
        rb2D.velocity = new Vector2(-speed*2, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
