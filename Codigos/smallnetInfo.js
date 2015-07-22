var txt :String;
guiText.text = txt;
//guiText.text = "Copyright © 2006 - 2014 Smallnet Todos los derechos reservados.\n";

guiText.material.color = Color.white;
//guiText.material.color = Color.yellow;
guiText.pixelOffset = Vector2 (0, 0);
guiText.alignment = TextAlignment.Center;
guiText.anchor = TextAnchor.MiddleCenter;

var i: float;

function Update(){
i=i+0.01;
if(i>=1)
i=1;
 // i=0; //para que blinkee
guiText.material.color = Color(1, 10, 0.06); 
guiText.material.color.a = i;
guiText.pixelOffset =Vector2(Screen.width/4, 14);
//Debug.Log(i);
}