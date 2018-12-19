using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{

    public enum States { Idle, Walk};
    public States miestado = States.Idle;
    public GameObject Player;
    
    public Transform target;
    public float speed;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (miestado)
        {
            case States.Idle:
                Idle();
                break;
            case States.Walk:
                Walk();
                break;
            default:
                print("Incorrect State");
                break;
        }
    }

    void Idle()

    {
        if (Vector3.Distance(transform.position, Player.transform.position) > 1 && Vector3.Distance(transform.position, Player.transform.position) < 8)
        {
            miestado = States.Walk;
        }

    }


    void Walk()
    {     

        if (Vector3.Distance(transform.position, Player.transform.position) > 8)
        {
            miestado = States.Idle;
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);



    }
        

}
