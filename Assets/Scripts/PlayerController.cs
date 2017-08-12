using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public UIController UIController;

	private void FixedUpdate ()
	{
		float x = Input.GetAxis("Horizontal");	// Horizontal は水平方向
		float z = Input.GetAxis("Vertical");	// Vertical は垂直方向

		// Player が持つ Rigidbody コンポーネントを取得
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		rigidbody.AddForce(x * 5, 0, z * 5);

		if(Input.GetKeyDown(KeyCode.Space) && rigidbody.velocity.y == 0)
			rigidbody.AddForce (0,256,0);
		
		if (Input.GetKeyDown (KeyCode.X))
			rigidbody.velocity = Vector3.zero;

		if (rigidbody.position.y < -30) {
			rigidbody.constraints = RigidbodyConstraints.FreezeAll;
			//reset ();
			UIController.ShowGameOverLabel();
		}
	}
	protected void controll (){
		
	}
	public void reset(){
		Rigidbody rigidbody = GetComponent<Rigidbody>();
		rigidbody.position = new Vector3(0,2,0);
		rigidbody.constraints = RigidbodyConstraints.None;
		rigidbody.velocity = Vector3.zero;
	}
}
