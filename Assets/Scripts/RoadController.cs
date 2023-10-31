using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    public GameObject[] Road;
    private void OnTriggerEnter(Collider other)
    {

        GameObject road = Instantiate(Road[Random.Range(0,2)], transform.position + new Vector3(0, 0, transform.GetChild(0).GetComponent<Renderer>().bounds.size.z * 2),transform.rotation);
        //road.GetComponent<RoadController>().Road = Road;
        Destroy(gameObject);

    }
}
