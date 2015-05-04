using UnityEngine;
using System.Collections;

public class ronchoControl : MonoBehaviour, Itocuheble3D
{
	public Animator animaciones;

	public Transform player; // Drag your player here
	private Vector2 fp; // first finger position
	private Vector2 lp; // last finger position
	private bool tocado = false;






	void Start()
	{
		animaciones = GetComponent<Animator>();

	}
	





	void Update()
	{

		if(tocado == true){
		foreach(Touch touch in Input.touches)
		{
			if (touch.phase == TouchPhase.Began)
			{
				fp = touch.position;
				lp = touch.position;
			}
			if (touch.phase == TouchPhase.Moved )
			{
				lp = touch.position;
			}
			if(touch.phase == TouchPhase.Ended)
			{
				if((fp.x - lp.x) > 80) // left swipe
				{
					Debug.Log("hola que hace");
				}
				else if((fp.x - lp.x) < -80) // right swipe
				{
					//Debug.Log("hola adios");
				}
				else if((fp.y - lp.y) < -80 ) // up swipe
				{
						animaciones.Play("LanzamientoArriba");
				}
			}
		}
		}

	
		if(Input.acceleration.magnitude > 3.5f){
			
			animaciones.Play("mareoAni");
			
		}
		

		
		
	}






	
	#region Itocuheble3D implementation
	
	
	
	public void OnTouchBegan ()
	{
		tocado = true;
		Debug.Log ("fui tocado ");
	//	animaciones.Play ("balance");
	}
	
	public void OnTouchEnded ()
	{

		Debug.Log ("toque terminado ");

	}



	public void OnTouchEndedAnywhere(){

		Debug.Log ("termine Donde sea ");
		tocado = false;


	}
	


	public void OnTouchMovedAnywhere()
	{


	}
	

	public void OnTouchBeganAnywhere()
	{
		Debug.Log ("Empece donde sea");
	}
	

	#endregion
	
	
	
	
}