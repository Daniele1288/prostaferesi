using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject zombie;

    public float timeMin = 1;
    public float timeMax = 10;

    public float time;
    private float timePassed;

    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(timeMin, timeMax);
    }

    // Update is called once per frame
    void Update()
    {

        if(timePassed >= time)
        {
            Instantiate(zombie, transform.position, Quaternion.identity);
            timePassed = 0;
            time = Random.Range(timeMin, timeMax);
        }

        timePassed += Time.deltaTime;

    }
}
