using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform Player;    

	private Vector3 offset;   

	private void Start ()
	{
		// MainCamera と Player の相対距離を求める
		offset = GetComponent<Transform>().position - Player.position;
	}

	private void Update ()
	{
		// Camera の座標に Player の座標と offset 加算した値を代入する     
		if(Player.position.y > -18)
			GetComponent<Transform>().position = Player.position + offset;
	}
}
