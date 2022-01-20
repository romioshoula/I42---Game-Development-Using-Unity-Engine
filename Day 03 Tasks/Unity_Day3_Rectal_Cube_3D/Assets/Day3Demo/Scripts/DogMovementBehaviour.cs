using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//enum Directions {  };


//[RequireComponent(typeof(Rigidbody))]
public class DogMovementBehaviour : MonoBehaviour
{

    #region Naming Convensions
    //PascalNamingConv -> Classes, Method, Structs, Enums
    //camelCaseNamingConv -> fields (variable) 
    #endregion
    
     
    string msg = "Hi, from";

     [SerializeField]
     float speed = 0.2f;
    [SerializeField]
     float movementForce = 1.5f;

    GameObject[] ball = null;
    Rigidbody rb;
    //Transform _transform;

    private void Awake()
    { 
        //LogMessage(msg + " Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hi, from Start");
        //print("Hey");
        //this.GetComponent<BallBehaviour>().enabled = false;
        //var ballBehaviours = this.GetComponents<BallBehaviour>();
        //for (int i = 0; i < ballBehaviours.Length; i++)
        //{
        //    ballBehaviours[i].enabled = false;
        //}


        //ball = GameObject.Find("Ball");


        ball = GameObject.FindGameObjectsWithTag("Respawn");

        foreach(GameObject go in ball)
        {
            print(go.GetComponent<Transform>().position);

        }
        //print(ball.GetComponent<Transform>().position);


        //_transform = GetComponent<Transform>();

        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        //LogMessage(msg + " OnEnable"); 
    }

    private void FixedUpdate()
    {
       //LogMessage(msg + " FixedUpdate");
        //Debug.Log(Time.fixedDeltaTime);

        
        rb.AddForce(transform.forward * movementForce);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up* 50); 
        }

    }
    // Update is called once per frame
    void Update()
    {

        #region DeltaTime
        //for (int i = 0; i < 1000; i++)
        //{
        //    Debug.Log("Hi, from Update");
        //}

        //this.GetComponent("Transform");
        //this.GetComponent<Transform>().position += new Vector3(0,0,1*speed * Time.deltaTime);
        //this.gameObject.GetComponent<BoxCollider>();
        //var firstGo = GameObject.FindObjectOfType<BallBehaviour>().gameObject;

        //firstGo.GetComponent<MeshFilter>();

        //_transform.position += new Vector3(0, 0, 1 * speed * Time.deltaTime);


        //transform.position.z += 1f*speed*Time.deltaTime;
        //Debug.Log(Time.deltaTime);

        #endregion

        #region move with Transform
        // Vector3 movementVector = new Vector3(0, 0, 1 * speed * Time.deltaTime);
        //Vector3 movementVector = new Vector3(0, 0, 0);

        //if (Input.GetKey(KeyCode.D))
        //{
        //    //movementVector = Vector3.right * speed * Time.deltaTime;
        //    movementVector += transform.right * speed * Time.deltaTime;

        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //    //movementVector = Vector3.forward * speed * Time.deltaTime;
        //    movementVector += transform.forward * speed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    //movementVector = Vector3.back * speed * Time.deltaTime;
        //    movementVector += -transform.forward * speed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    //movementVector = Vector3.left * speed * Time.deltaTime;
        //    movementVector += -transform.right * speed * Time.deltaTime;
        //}



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

        //transform.position += movementVector;


        //transform.Translate(movementVector);
        // this.transform.transform.transform.transform.transform.Translate(movementVector);
        #endregion


        //if (Input.GetKey(KeyCode.W))
        //{
      
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    GetComponent<Rigidbody>().AddForce(Vector3.back);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    GetComponent<Rigidbody>().AddForce(Vector3.left);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    GetComponent<Rigidbody>().AddForce(Vector3.right);
        //}

    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided with" + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("exity collision with" + collision.gameObject.name);

    }




    void LogMessage(string msg)
    {
        Debug.Log(msg, this.gameObject);
        //print(msg);
    }
} 