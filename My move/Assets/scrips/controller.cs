using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;

public class controller : MonoBehaviour
{

    public float speed = 10000.0f;
    Rigidbody rd;

    Vector3 prepos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        rd.AddForce(0f ,0f,speed);
        prepos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //필드를 기준으로 x,y,z를 움직인다
        if(Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A) == true)
        {
            rd.AddForce(-speed*0.05f,0f,0f);
            speed +=speed*0.005f;
            Debug.Log("왼쪽");
        }
        if(Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D) == true)
        {
            rd.AddForce(speed*0.05f,0f,0f);
            speed +=speed*0.005f;
            Debug.Log("오른쪽");
        }
        if(Input.GetKey(KeyCode.Space) == true)
        {
            rd.AddForce(0f,speed*0.05f,0f);
            speed +=speed*0.005f;
            Debug.Log("점프");
        }
        if(Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W) == true)
        {
            rd.AddForce(0f,0f,speed*0.05f);
            speed +=speed*0.005f;
            Debug.Log("위");
        }
        if(Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S) == true)
        {
            rd.AddForce(0f,0f,-speed*0.05f);
            speed +=speed*0.005f;
            Debug.Log("아래");
        }
        
        /*
        //물체의 기준으로 x,y,z를 움직인다
        if(Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A) == true)
        {
            transform.Translate(Vector3.left*speed*Time.deltaTime);
            Debug.Log("왼쪽");
        }
        if(Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D) == true)
        {
            transform.Translate(Vector3.right*speed*Time.deltaTime);
            Debug.Log("오른쪽");
        }
        if(Input.GetKey(KeyCode.Space) == true)
        {
            transform.Translate(Vector3.up*speed*Time.deltaTime);
            Debug.Log("점프");
        }
        if(Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W) == true)
        {
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
            Debug.Log("위");
        }
        if(Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S) == true)
        {
            transform.Translate(Vector3.back*speed*Time.deltaTime);
            Debug.Log("아래");
        }
        */
    }

    void OnCollisionEnter(Collision collision)
    {
        
        speed =speed * 0.9f;
        if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("OnCollisionEnter");
            //입사각
            Vector3 currpos = collision.transform.position; //충돌위치
            Vector3 incomvec = currpos - prepos;

            //법선벡터
            Vector3 normalvec = collision.contacts[0].normal;

            //법사각(방향 O , 크기 X)
            Vector3 reflectvec = Vector3.Reflect(incomvec,normalvec);
            reflectvec = reflectvec.normalized; //크기 1

            rd.AddForce(reflectvec*speed);

            prepos = currpos;

        }

    }
}
