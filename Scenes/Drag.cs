using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Plane dragPlane;
    private Camera myMainCamera;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        myMainCamera = Camera.main;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnMouseDown()
    {
        dragPlane = new Plane(myMainCamera.transform.forward, transform.position); 
        Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition); 

        float planeDist;
        dragPlane.Raycast(camRay, out planeDist); 
        offset = transform.position - camRay.GetPoint(planeDist);
    }

    void OnMouseDrag()
    {   
        Ray camRay = myMainCamera.ScreenPointToRay(Input.mousePosition); 

        float planeDist;
        dragPlane.Raycast(camRay, out planeDist);
        transform.position = camRay.GetPoint(planeDist) + offset;
    }
}
