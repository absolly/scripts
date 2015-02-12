using UnityEngine;
using System.Collections;

public class minimapposition : MonoBehaviour {
	public float width;
	public float height;


	// Use this for initialization
	void Update () 
	{

		Camera camera = GetComponent<Camera>();

		width = Screen.width;
		height = Screen.height;
		// obtain camera component so we can modify its viewport

			Rect rect = camera.rect;
			
			rect.width = (width*0.3f)/1000;
			rect.height = (width*0.3f)/1000;
			rect.x = (width-rect.width)/1000;
			rect.y = ((height/2)-(rect.height/2))/1000;
			
			camera.rect = rect;

}
}