using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public GameObject player;
    private GameObject minMapView;
    
    
    void Start()
    {
        minMapView = GameObject.Find("MinimapCamera");
    }


    // Update is called once per frame
    void Update()
    {
        minMapView.transform.position = new Vector3(player.transform.position.x, minMapView.transform.position.y, player.transform.position.z);
    }
}
