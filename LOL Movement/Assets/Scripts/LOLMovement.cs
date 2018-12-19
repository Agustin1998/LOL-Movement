using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOLMovement : MonoBehaviour {

    public Transform target;
    public float speed = 10;
    
    

    // Use this for initialization
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0))
        {
            Debug.Log(hit.distance);
            transform.position = new Vector3(hit.point.x, 0.6f, hit.point.z);
        }

        transform.position = Vector3.MoveTowards(transform.position, transform.position, speed * Time.deltaTime);
    }
}
