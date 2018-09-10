using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthblock : MonoBehaviour
{
    public List<GameObject> cubes;

    private GameObject _current;
    private int maxHits;
    private int hits;
    void Start()
    {
        hits = 0;
        maxHits = cubes.Count;
        RoadBlockPosition blockPosition = GetComponent<RoadBlockPosition>();
    }

    void Update()
    {

    }

    private void setNext()
    {
        if (hits != -1)
        {
            Destroy(_current);
        }

        hits++;
        if (hits < maxHits)
        {
            _current = Instantiate(cubes[hits]);
            _current.transform.position += transform.position;
        }
    }

}
