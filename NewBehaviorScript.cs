using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ping-pong animate background color
public class NewBehaviourScript : MonoBehaviour
{
	public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public Color color3 = Color.yellow; //try to change from red to yellow to blue
    public float duration = 0.1f;

    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Mathf.PingPong(Time.time, duration) / duration;
        cam.backgroundColor = Color.Lerp(color1, color2, t);
    }
}
