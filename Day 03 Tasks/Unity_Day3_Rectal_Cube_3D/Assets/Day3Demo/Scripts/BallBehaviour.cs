using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{

    //// Start is called before the first frame update
    //void Start()
    //{

    //    //print(DogMovementBehaviour.age);
    //}

    // Update is called once per frame
    void Update()
    {
         

    }
    private void Start()
    {
        SendMessage(nameof(Hamada));
    }
    void Hamada()
    {
        Debug.Log("Hhhhhhhhhhh");
    }

    //private void OnMouseDown()
    //{
    //    GetComponent<MeshRenderer>().material.color = Color.red;
    //}

    //private void OnMouseOver()
    //{
    //   // GetComponent<MeshRenderer>().material.color =  Color.cyan;

    //}

    //private void OnMouseEnter()
    //{
    //    GetComponent<MeshRenderer>().material.color = Color.blue;

    //}

    //private void OnMouseExit()
    //{
    //    GetComponent<MeshRenderer>().material.color = Color.yellow;

    //}
}
