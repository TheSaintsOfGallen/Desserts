using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ClickOnTreasure : MonoBehaviour {

    private bool flag = false;

    void OnMouseDown () {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
		if (Physics.Raycast(ray,out hit) && !flag) {
			Debug.Log("target hit!!");
			Debug.Log(hit.collider.name);
            ScreenCapture.CaptureScreenshot("screen_"+hit.collider.name+".png"); 
			flag = true;
        }
        
      
    }
	
}
