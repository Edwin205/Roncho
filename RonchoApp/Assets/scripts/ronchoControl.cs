using UnityEngine;
using System.Collections;

public class ronchoControl : MonoBehaviour, Itocuheble3D  
{
	public Animator animaciones;

	public float minSwipeDistY;
	public float minSwipeDistX;
	private Vector2 startPos;
	bool touched= false;

	void Start()
	{
		animaciones = GetComponent<Animator>();

	}


	void Update()
	{

		if(touched == true){
		if (Input.touchCount > 0) {
			
			Touch touch = Input.touches [0];
			
			
			
			switch (touch.phase) {
				
			case TouchPhase.Began:
				
				startPos = touch.position;
				
				break;
				
				
				
			case TouchPhase.Ended:
				
				float swipeDistVertical = (new Vector3 (0, touch.position.y, 0) - new Vector3 (0, startPos.y, 0)).magnitude;
				
				if (swipeDistVertical > minSwipeDistY) {
					
					float swipeValue = Mathf.Sign (touch.position.y - startPos.y);
					
					if (swipeValue > 0) {
						animaciones.Play ("lanzamientoArriba");
					}//up swipe
					
					
					
					else if (swipeValue < 0) {
						
					}//down swipe
					
					
					
				}
				
				float swipeDistHorizontal = (new Vector3 (touch.position.x, 0, 0) - new Vector3 (startPos.x, 0, 0)).magnitude;
				
				if (swipeDistHorizontal > minSwipeDistX) {
					
					float swipeValue = Mathf.Sign (touch.position.x - startPos.x);
					
					if (swipeValue > 0) {
						animaciones.Play ("lanzamientoDer");
					}//right swipe
					
					
					
					else if (swipeValue < 0) {
						animaciones.Play ("lanzamientoIzq");
					}//left swipe
					
					
					
				}
				break;
			}

		}
		if (Input.acceleration.magnitude > 3.5f) {

			animaciones.Play ("mareoAni");

		}
	}
	}

	
	#region Itocuheble3D implementation
	
	
	
	public void OnTouchBegan ()
	{


		touched = true;
			

	}
	
	public void OnTouchEnded ()
	{

		touched = false;
	}

	public void OnTouchMoved()
	{


	}

	public void OnTouchEndedAnywhere(){

	}
	
	public void OnTouchStayed ()
	{


	}

	public void OnTouchMovedAnywhere()
	{

	}
	

	public void OnTouchBeganAnywhere()
	{

	}
	
	
	
	#endregion
	
	
	
	
}