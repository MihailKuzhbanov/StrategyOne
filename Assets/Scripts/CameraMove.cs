using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

    
    public float camMovSpd, camRotSpd, camScrSpd;                   //скорости камеры, перемещение, вращение, промотка
    public float minYPos, maxYPos;                                  //минимальная, максимальная высота камеры
    public Vector3 newPos = new Vector3();                          //новое положение камеры
    public float yRot = 0;                                          //поворот по У


    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        newPos = Vector3.zero;

        if (Input.mousePosition.x <= 5)
        {
            newPos.x -= 25;
            transform.Translate(newPos * camMovSpd);
        }
        if (Input.mousePosition.y <= 5)
        {
            newPos.z -= 10;
            newPos.y -= 10;
            transform.Translate(newPos * camMovSpd);
        }
        if (Input.mousePosition.x >= (Screen.width - 5))
        {
            newPos.x +=25;
            transform.Translate(newPos * camMovSpd);
        }

        if (Input.mousePosition.y >= (Screen.height - 5))
        {
            newPos.z += 10;
            newPos.y += 10;
            transform.Translate(newPos * camMovSpd);
        }
    }
}
