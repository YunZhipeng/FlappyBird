using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float boxColliderWidth; 

	// Use this for initialization
	void Start () {
        groundCollider = GetComponent<BoxCollider2D>();//获取Ground的BoxCollider2D组件
        boxColliderWidth = groundCollider.size.x;//boxColliderWidth等于groundCollider的x值得大小
	}
	
	// Update is called once per frame
	void Update () {
        //当transform.position.x < -2*boxColliderWidth时，背景的位置向x值移动4 * boxColliderWidth的距离
        if (transform.position.x < -2*boxColliderWidth) 
        {
            transform.position = new Vector3(transform.position.x + 4 * boxColliderWidth, transform.position.y, transform.position.z);
        }
	}
}
