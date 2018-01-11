using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateText : MonoBehaviour {
	public Text rot1;
	public Text rot2;
	public Text rot3;
	
    public Text handPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// それぞれのアームの回転角を表示
		rot1.text = "First arm:" + GameObject.Find("Origin").transform.localEulerAngles.y.ToString();
		rot2.text = "Second arm:" + GameObject.Find("connect1").transform.localEulerAngles.y.ToString();
		rot3.text = "Third arm:" + GameObject.Find("connect2").transform.localEulerAngles.y.ToString();
        handPosition.text = "Hand x:" + GameObject.Find("hand").transform.position.x.ToString()+"y:"+GameObject.Find("hand").transform.position.z.ToString();
    }
}
