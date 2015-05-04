using UnityEngine;
using System.Collections;

public class ronchoControl : MonoBehaviour, Itocuheble3D
{
	public Animator animaciones;

	public Transform player; // Drag your player here
	private Vector2 fp; // first finger position
	private Vector2 lp; // last finger position
	public bool tocado = false;

	
	void Start()
	{
		animaciones = GetComponent<Animator>();

	}

	void Update(){

			foreach (Touch touch in Input.touches) {

				if (touch.phase == TouchPhase.Began) {
					fp = touch.position;
					lp = touch.position;
					Debug.Log ("Valores de first" + fp);
					Debug.Log ("Valores de last" + lp); 
				}
				if (touch.phase == TouchPhase.Moved) {
					lp = touch.position;
					
				}
				if (touch.phase == TouchPhase.Ended ) {
					
					if (tocado == true){
					if ((fp.x - lp.x) > 80) { // left swipe
						animaciones.Play("LanzamientoIzq");
					} else if ((fp.x - lp.x) < -80) { // right swipe
						animaciones.Play ("LanzamientoDer");
					} else if ((fp.y - lp.y) < -80) { // up swipe
						animaciones.Play ("LanzamientoArriba");
					} 
						tocado = false;
					
				}
				}
			}


	
			if (Input.acceleration.magnitude > 3.5f) {
				
				animaciones.Play ("mareoAni");
				
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

		//Debug.Log ("toque terminado ");

	}



	public void OnTouchEndedAnywhere(){

		//Debug.Log ("termine Donde sea ");
		//tocado = false;


	}
	


	public void OnTouchMovedAnywhere()
	{
		//Debug.Log ("Me movi");

	}
	

	public void OnTouchBeganAnywhere()
	{
		//Debug.Log ("Empece donde sea");
	}
	

	#endregion
	
	
	
	
}