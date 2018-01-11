using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	
	float rot;
	public Transform target;
	//回転中心の座標
	private Vector3 targetPos;
	// Use this for initialization
	void Start () {
		//targetにArm1という名前のオブジェクトを見つけてアクセス
		target = GameObject.Find("Origin").transform;
		//targetPosにArm1の位置情報を取得
		targetPos = target.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)){
			rot = Time.deltaTime * 100;
			transform.RotateAround(targetPos, target.up, rot);

		}
		if(Input.GetKey(KeyCode.S)){
			rot = Time.deltaTime * -100;
			transform.RotateAround(targetPos, target.up, rot);


		}

	}
}
