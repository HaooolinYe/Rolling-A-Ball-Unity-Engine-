using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    public float angle;
    int x;
    int y;
    int z;
    int xcount;
    int ycount;
    int zcount;

    void Update()
    {
        x = Random.Range(1, 600);
        y = Random.Range(1, 600);
        z = Random.Range(1, 600);
        xcount = Random.Range(1, x);
        ycount = Random.Range(1, y);
        zcount = Random.Range(1, z);
        transform.Rotate(new Vector3( xcount , ycount , zcount) * Time.deltaTime);

    }
}
