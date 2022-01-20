using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Directions { Left, Right, Up, Down }

public class DogBehaviour : MonoBehaviour
{

    [SerializeField]
    float speed = 0.2f;
    [SerializeField]
    float movementForce = 1.5f;
    Rigidbody rb;

    [SerializeField]
    bool ishawhawand_NawNaw;

    [SerializeField]
    Directions directions;


    //[SerializeField]
    //GameObject ball;

    [SerializeField]
    BallBehaviour ball;

    public BallBehaviour Ball { get => ball; }

    private void Awake()
    {
        SendMessage(nameof(Hamada));
    }
    // Start is called before the first frame update
    void Start()
    {

      rb = GetComponent<Rigidbody>();
        //ball = GameObject.FindGameObjectWithTag("Balls");


        var childrenNames = transform.GetComponentsInChildren<Transform>();


        foreach (var item in childrenNames)
        {
            if (item.transform.parent != null)
                Debug.Log(item.transform.parent.gameObject);
            item.gameObject.AddComponent<CapsuleCollider>();
        }
    } 
     
    void Hamada()
    {
        Debug.Log("Hello from Hamda 1");
    }


    //called every 0.02(timestep) 
    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * movementForce);
    }
    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey(KeyCode.E))
        { 
            transform.Rotate(0, 1, 0);   //xyz -> xyzw 3.14568
            rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.Q))
        {

            transform.Rotate(new Vector3(0, -1, 0));   //xyz -> xyzw 
            rb.velocity = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
           Ball.GetComponent<MeshRenderer>().enabled = false;
            //ball.SetActive(! ball.activeInHierarchy);
        }

        //var childrenNames = transform.GetComponentsInChildren<Transform>();


        //foreach (var item in childrenNames)
        //{
        //    if(item.transform.parent != null)
        //        Debug.Log(item.transform.parent.gameObject);
        //    item.gameObject.AddComponent<BoxCollider>(); 
        //}
        //Debug.Log(transform.childCount);
    }
}
