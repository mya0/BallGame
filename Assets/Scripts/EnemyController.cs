using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public UIController UIController;
	protected void OnTriggerEnter (Collider hit)
	{
		Debug.Log("死んだよ！");
		if (hit.CompareTag ("Player")) {
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			UIController.ShowGameOverLabel();
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
