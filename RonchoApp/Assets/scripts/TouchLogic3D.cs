using UnityEngine;
using System.Collections;

public class TouchLogic3D : MonoBehaviour {


	public static int currTocuh = 0;
	private int touch2wathch= 64;
	private Ray ray;
	private RaycastHit rayHitInfo = new RaycastHit();
	private Itocuheble3D touchedObjects = null;

	
	
	void Update () 
	{





		for(int i = 0; i < Input.touchCount;i++)
		{
			currTocuh = i;
			ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
			
			if(Physics.Raycast(ray, out rayHitInfo)){
				
				touchedObjects = rayHitInfo.transform.GetComponent(typeof(Itocuheble3D)) as Itocuheble3D;

				
				if(touchedObjects != null){
					switch(Input.GetTouch(i).phase)
					{
					case TouchPhase.Began:
						touchedObjects.OnTouchBegan();
						touch2wathch = currTocuh;
						break;
				
					case TouchPhase.Ended:
						touchedObjects.OnTouchEnded();
						break;


					}
				}
		
			}

			else if( touchedObjects != null && touch2wathch == currTocuh){
					switch(Input.GetTouch(i).phase)
					{
				     
				case TouchPhase.Began:
					touchedObjects.OnTouchBeganAnywhere();
					break;
						
					case TouchPhase.Ended:
						touchedObjects.OnTouchEndedAnywhere();
					touchedObjects = null;
						break;
	

				case TouchPhase.Moved:

					touchedObjects.OnTouchMovedAnywhere();
					break;
						
			
				
			}
			
			
			
			
			
			
		}
	}
}
}