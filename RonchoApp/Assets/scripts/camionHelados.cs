using UnityEngine;
using System.Collections;

public class camionHelados : MonoBehaviour,Itocuheble3D {

	public Animator helados;
	public Animator roncho;




	void OnMouseDown()
	{
		helados.Play ("camionMov");
		roncho.Play ("heladoAni");
	}





	#region Itocuheble3D implementation
	public void OnTouchBegan ()
	{
		helados.Play ("camionMov");
		roncho.Play ("heladoAni");
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

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
