using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posizionePistola : MonoBehaviour
{
    public GameObject player;
    public GameObject mirino;

    Transform gunPosition;
    Transform playerPosition;
    Transform mirinoPosition;

    public static float tan;
    float angolo;
    public static float rotation;

    void Start()
    {
        gunPosition = GetComponent<Transform>();
        playerPosition = player.GetComponent<Transform>();
        mirinoPosition = mirino.GetComponent<Transform>();

        angolo = Mathf.PI/2;

        gunPosition.position = new Vector2(playerPosition.position.x + Mathf.Cos(angolo), playerPosition.position.y + Mathf.Sin(angolo));

    }

    void Update()
    {
        tan = (mirinoPosition.position.y - playerPosition.position.y)/(mirinoPosition.position.x - playerPosition.position.x - 0.000001f);

        if(mirinoPosition.position.x > playerPosition.position.x)
        {
            angolo = Mathf.Atan(tan);
        }

        if(mirinoPosition.position.x < playerPosition.position.x)
        {
            angolo = Mathf.Atan(tan) + Mathf.PI;
        }


        gunPosition.position = new Vector2(playerPosition.position.x + Mathf.Cos(angolo), playerPosition.position.y + Mathf.Sin(angolo));

        rotation = angolo * 180/Mathf.PI;

        if(rotation > 90f)
        {
            gunPosition.localRotation = Quaternion.Euler(180f, 0f, -rotation);
        }
        else
        {
            gunPosition.localRotation = Quaternion.Euler(0f, 0f, rotation);
        }
    }
}
