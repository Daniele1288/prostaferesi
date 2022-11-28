using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generalInfo : MonoBehaviour
{
    public static float width;
    public static float height;

    public static float mouseX;
    public static float mouseY;

    public static bool controller = false;

    public GameObject player;
    public GameObject mirino;

    public static Transform playerPosition;
    public static Transform mirinoPosition;

    private void Awake() 
    {
        width = Screen.width;
        height = Screen.height;
    }

    private void Update() 
    {
        mouseX = Input.mousePosition.x;
        mouseY = Input.mousePosition.y;

        if(!(Input.GetAxis("motionX") == 0) || !(Input.GetAxis("motionY") == 0))
        {
            controller = false;
        }

        if(!(Input.GetAxis("Mouse X") == 0) || !(Input.GetAxis("Mouse Y") == 0))
        {
            controller = true;
        }

        playerPosition = player.GetComponent<Transform>();
        mirinoPosition = mirino.GetComponent<Transform>();
    
    }
}
