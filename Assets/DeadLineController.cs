﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLineController : MonoBehaviour
{
	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//UnityちゃんとDeadLineの距離
	private float difference;

	// Use this for initialization
	void Start ()
	{	
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
		//UnityちゃんとDeadLineの位置（z座標）の差を求める
		this.difference = unitychan.transform.position.z-this.transform.position.z;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Unityちゃんの位置に合わせて移動
		this.transform.position = new Vector3(0,this.transform.position.y,this.unitychan.transform.position.z-difference);
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		//他のオブジェクトに衝突した場合
		if(other.gameObject.tag == "CarTag" ||other.gameObject.tag == "TrafficConeTag" ||other.gameObject.tag == "CoinTag" )
		{
			//ゲームオブジェクトを破棄
			Destroy(other.gameObject);
		}
	}
}
