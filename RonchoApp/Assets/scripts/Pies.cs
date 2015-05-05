using UnityEngine;
using System.Collections;

public class Pies : MonoBehaviour,Itocuheble3D {

	public Animator animaciones;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	#region Itocuheble3D implementation
	public void OnTouchBegan ()
	{
		animaciones.Play ("balance");
	}
	public void OnTouchEnded ()
	{
		
	}
	public void OnTouchBeganAnywhere ()
	{
		
	}
	public void OnTouchEndedAnywhere ()
	{
		
	}
	public void OnTouchMovedAnywhere ()
	{
		
	}
	#endregion
}
