
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate3 : MonoBehaviour {
	
	float rot;
	public Transform target;
	//回転中心の座標
	private Vector3 targetPos;
	// Use this for initialization
	void Start () {
		//targetにArm1という名前のオブジェクトを見つけてアクセス
		target = GameObject.Find("connect2").transform;
		//targetPosにArm1の位置情報を取得
		targetPos = target.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.G)){
			rot = Time.deltaTime ;
			transform.RotateAroundLocal(target.up, rot);

		}
		if(Input.GetKey(KeyCode.H)){
			rot = Time.deltaTime * -1;
			transform.RotateAroundLocal(target.up, rot);


		}

	}
}
