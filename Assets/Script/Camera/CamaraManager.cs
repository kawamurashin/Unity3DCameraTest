using UnityEngine;
using System.Collections;

public class CamaraManager : MonoBehaviour {
    private Camera _camera;

    // Use this for initialization
	private void Start ()
	{
	    _camera = Camera.main;

	}
	
	// Update is called once per frame
	private void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            float v = 0.5f;
            var forward = _camera.transform.forward;

            var x = forward.x;
            var y = forward.y;
            var z = forward.z;
            var r = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2) + Mathf.Pow(z, 2));
            var theta = Mathf.Acos(y/ Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2) + Mathf.Pow(z, 2)));
            var phi = Mathf.Atan2(z, x);
 
            Vector3 vector = Vector3.zero;
            vector.x = v*Mathf.Sin(theta)*Mathf.Cos(phi);
            vector.y = v*Mathf.Cos(theta);
            vector.z = v*Mathf.Sin(theta)*Mathf.Sin(phi);
            _camera.transform.localPosition += vector;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
           
            float v = -0.5f;
            var forward = _camera.transform.forward;

            var x = forward.x;
            var y = forward.y;
            var z = forward.z;
            var r = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2) + Mathf.Pow(z, 2));
            var theta = Mathf.Acos(y / Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2) + Mathf.Pow(z, 2)));
            var phi = Mathf.Atan2(z, x);

            Vector3 vector = Vector3.zero;
            vector.x = v * Mathf.Sin(theta) * Mathf.Cos(phi);
            vector.y = v * Mathf.Cos(theta);
            vector.z = v * Mathf.Sin(theta) * Mathf.Sin(phi);
            _camera.transform.localPosition += vector;


        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 vector = _camera.transform.localEulerAngles;
            vector.y += 1.00f;
            _camera.transform.localEulerAngles = vector;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            
            Vector3 vector = _camera.transform.localEulerAngles;
            vector.y += -1.00f;
            _camera.transform.localEulerAngles = vector;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            Vector3 vector = _camera.transform.localEulerAngles;
            vector.x += 1.00f;
            _camera.transform.localEulerAngles = vector;
        }
        if (Input.GetKey(KeyCode.X))
        {
            Vector3 vector = _camera.transform.localEulerAngles;
            vector.x += -1.00f;
            _camera.transform.localEulerAngles = vector;
        }
        
    }
}
