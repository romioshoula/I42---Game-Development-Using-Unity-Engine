using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadHandler : MonoBehaviour
{
    
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = transform.parent.GetComponent<DogBehaviour>().Ball.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        #region Scale up & Down
        //Debug.Log(transform.lossyScale);
        //Debug.Log("-->---> " + transform.localScale);

        //if (Input.GetKeyDown(KeyCode.Z))
        //{
        //    transform.localScale += Vector3.one; //new Vector3(1,1,1)
        //}
        //if (Input.GetKeyDown(KeyCode.X))
        //{
        //    transform.localScale -= Vector3.one; //new Vector3(1,1,1)
        //}
        #endregion

        if (Input.GetMouseButtonDown(0))
        {
           var ballInstance =  Instantiate(ball,this.transform.position + Vector3.forward,Quaternion.identity);

            if(ballInstance && (ballInstance.GetComponent<Rigidbody>() != null))
                    ballInstance.GetComponent<Rigidbody>().AddForce(Vector3.forward*150);


            Debug.Log(ballInstance.transform.GetComponentInChildren<BallBehaviour>());
            
        }
    }
}
