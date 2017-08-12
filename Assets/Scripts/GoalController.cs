using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour {

	public UIController UIController;
	protected void OnTriggerEnter (Collider hit)
	{
		Debug.Log("ゴールしたよ！");
		if (hit.CompareTag ("Player")) {
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			UIController.ShowGameClearLabel();
		}
		//

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
