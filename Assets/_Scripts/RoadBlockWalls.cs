using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBlockWalls : MonoBehaviour
{
    public List<GameObject> wallPrefabs;

    private GameObject[] wallsFar;
    private GameObject[] wallsNear;
    private int wallLenght = 10;
    private Vector3 wallOffset = new Vector3(0.0f, 0.0f, 1.0f);
    private Vector3 farOffset = new Vector3(-5.0f, 0.0f, 0.0f);
    private Vector3 nearOffset = new Vector3(5.0f, 0.0f, 0.0f);


    // Use this for initialization
    void Start()
    {
        RoadBlockPosition blockPosition = GetComponent<RoadBlockPosition>();
        transform.position = new Vector3(0, transform.position.y, blockPosition.position * 10 + 0.5f);
        wallsFar = new GameObject[wallLenght];
        wallsNear = new GameObject[wallLenght];
        CreateWall(farOffset);
        CreateWall(nearOffset);

        //Transform selfTransform = transform;
        //Transform parentTransform = transform.parent;
        //transform.position = new Vector3(0, transform.position.y, blockPosition.position * 10);
    }

    private void CreateWall(Vector3 offset)
    {
        int wallOptions = wallPrefabs.Count;
        int wallLenghtCreated = 0;
        while (wallLenghtCreated < wallLenght)
        {
            int randomIndex = Random.Range(0, wallOptions);

            int randomLenght = Random.Range(1, wallLenght - wallLenghtCreated);
            for (int x = wallLenghtCreated; x < wallLenghtCreated + randomLenght; ++x)
            {
                GameObject wallBrick = Instantiate(wallPrefabs[randomIndex]);
                wallBrick.transform.position += transform.position + x * wallOffset + offset;
                wallsFar[x] = wallBrick;
            }
            wallLenghtCreated += randomLenght;

        }
    }
}
