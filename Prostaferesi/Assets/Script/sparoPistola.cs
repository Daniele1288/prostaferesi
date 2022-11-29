using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparoPistola : MonoBehaviour
{
    public GameObject proiettile;
    public GameObject firePoint;

    Vector2 position;
    Vector2 firePosition;

    public float delay = 1;
    float time;

    public int colpiMax = 12;

    int colpi;

    // Start is called before the first frame update
    void Start()
    {
        time = delay;
        colpi = colpiMax;

        position = firePoint.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
      position = firePoint.GetComponent<Transform>().position;

        if(Input.GetAxis("Fire1") > 0 && colpi > 0 && time >= delay)
        {
            Instantiate(proiettile, position, Quaternion.Euler(0f, 0f, posizionePistola.rotation));
            time = 0;
        }

        time += Time.deltaTime;
    }
}
