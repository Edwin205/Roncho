using UnityEngine;
using System.Collections;

public class playVideo : MonoBehaviour,Itocuheble3D {
	#region Itocuheble3D implementation

	void OnMouseDown()
	{
		Application.LoadLevel("ExampleNoneGui");
	}



	public void OnTouchBegan ()
	{
		Application.LoadLevel("ExampleNoneGui");
	}
	public void OnTouchEnded ()
	{
		//throw new System.NotImplementedException ();
	}
	public void OnTouchBeganAnywhere ()
	{
		//throw new System.NotImplementedException ();
	}
	public void OnTouchEndedAnywhere ()
	{
		//throw new System.NotImplementedException ();
	}
	public void OnTouchMovedAnywhere ()
	{
		//throw new System.NotImplementedException ();
	}
	#endregion

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
