using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClearButtonController : MonoBehaviour {

	public UIController uc;

	public void OnClick() {
		Debug.Log("Retry");
		uc.restart ();
	}
}
