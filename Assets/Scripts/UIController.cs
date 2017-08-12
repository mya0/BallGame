﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	public Text GameClearLabel;
	public Text GameOverLabel;
	public Button RetryButton;
	public PlayerController pc;

	private void Start () 
	{
		// 開始時に表示を消す
		GameClearLabel.gameObject.SetActive(false);
		GameOverLabel.gameObject.SetActive(false);
		RetryButton.gameObject.SetActive(false);
	}
	public void restart(){
		Start ();
		pc.reset ();
	}

	public void ShowGameClearLabel()
	{
		// 開始時に表示する
		GameClearLabel.gameObject.SetActive(true);	
		RetryButton.gameObject.SetActive (true);
	}
	public void ShowGameOverLabel(){
		GameOverLabel.gameObject.SetActive(true);
		RetryButton.gameObject.SetActive (true);
	}
}
