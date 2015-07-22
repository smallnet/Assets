using UnityEngine;
using System.Collections;

public class DrawPath : MonoBehaviour{
	public Transform[] path;
	public float percentage;
	public float vel;
	
	public GameObject pantalla;
	//public Camera camara;
	
	public GameObject preguntas;
	public GUIText texto;
	
	public bool state=false;

	void OnGUI () {
		
		if (Input.GetKeyDown(KeyCode.Escape))
		{ state=true;} 
	
		if (state==true){
		//percentage=GUI.HorizontalSlider(new Rect(23,194,204,40),percentage,0,1);
		percentage=percentage+vel;
		print(percentage*100);
		iTween.PutOnPath(gameObject,path,percentage);		
		//You can cause the object to orient to its path by calculating a spot slightly ahead on the path for a look at target:
		transform.LookAt(iTween.PointOnPath(path,percentage+.0005f));
		}
		
		if ((percentage*100)>2.3)
		{
		state=false;
		pregunta1();
		 //iTween.FadeTo(preguntas, iTween.Hash("alpha",1));
			texto.text ="A que region \n" + "pertenecen estas figuras?";
				
		}
	
	if (Input.GetKeyDown(KeyCode.H))
		{ state=true;
		}
	
	}	
	
	
	void OnDrawGizmos(){
		iTween.DrawPath(path);
	}
	
	void pregunta1(){
		Debug.Log("A que region pertenecen estas figuras?");
	}
}

