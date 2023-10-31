using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 200;
    public bool creatingSection = false;
    public int secNum;
    GameObject[] roads;

    private void Start()
    {
        roads = new GameObject[section.Length];
        roads[0] = section[0];
        roads[1] = section[1];
    }

    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        Destroy(roads[0],30);
        roads[0] = roads[1];
        
        secNum = Random.Range(0, 2);
        
        GameObject road = Instantiate(section[secNum], new Vector3(0, 0, zPos + 300),Quaternion.identity);
        roads[1] = road;
        zPos += 600;
        yield return new WaitForSeconds(15);
        creatingSection = false;
    }
}
