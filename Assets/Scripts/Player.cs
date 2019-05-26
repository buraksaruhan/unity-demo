using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement(){
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0,speed * Time.deltaTime,0);     
            anim.SetInteger("direction",0);  
            Debug.Log(anim.GetInteger("direction"));
        }
        else if(Input.GetKey(KeyCode.S)){
            anim.SetInteger("direction",1);
            transform.Translate(0,-speed * Time.deltaTime,0);
            Debug.Log(anim.GetInteger("direction"));
        }
        else if(Input.GetKey(KeyCode.A)){
            anim.SetInteger("direction",2);
            transform.Translate(-speed * Time.deltaTime,0,0);
            Debug.Log(anim.GetInteger("direction"));
        }
        else if(Input.GetKey(KeyCode.D)){
            anim.SetInteger("direction",3);
            transform.Translate(speed * Time.deltaTime,0,0);
            Debug.Log(anim.GetInteger("direction"));
        }else{
            anim.SetInteger("direction",99);
            Debug.Log(anim.GetInteger("direction"));
        }


    }
}
