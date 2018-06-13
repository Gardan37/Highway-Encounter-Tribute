using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthblock : MonoBehaviour
{
    public GameObject cube;

    private GameObject[] cubes;
    private Vector3 offset = new Vector3(0.0f, 0.5f, 0.0f);

    void Start()
    {
        cubes = new GameObject[3];
        for (int x = 0; x < 3; ++x)
        {
            GameObject newcube = Instantiate(cube);
            newcube.transform.position = transform.position + x * offset;
            cubes[x] = newcube;
        }

    }

    void Update()
    {

    }
}
