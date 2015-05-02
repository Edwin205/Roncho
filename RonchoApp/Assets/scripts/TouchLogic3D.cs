using UnityEngine;
using System.Collections;

public class TouchLogic3D : MonoBehaviour {

	private int touch2Wathc = 64;
	public static int currTocuh = 0;
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
				Debug.Log(touchedObjects);
				
				if(touchedObjects != null){
					switch(Input.GetTouch(i).phase)
					{
					case TouchPhase.Began:
						touchedObjects.OnTouchBegan();
						touch2Wathc = currTocuh;
						break;


					case TouchPhase.Moved:
						touchedObjects.OnTouchMoved();
						break;
						
					case TouchPhase.Ended:
						touchedObjects.OnTouchEnded();
						break;
						
			
						
					case TouchPhase.Stationary:
						touchedObjects.OnTouchStayed();
						break;

				    
						
					}
				}
			}

			else if(touchedObjects != null && touch2Wathc == currTocuh){
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