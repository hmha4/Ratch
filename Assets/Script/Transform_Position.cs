﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//캐릭터 충돌할 때 character controller 붙어있으면 Iscollision 이런게 작동하지않는다.
//캐릭터 컨트롤러 스크립트를 짜야하는것갗다.,

public class Transform_Position : MonoBehaviour
{


    public Vector3 v1;



    void TransformPosition(Collision col)
    {

        v1 = col.transform.position;
        v1.x = 0.0f;
        v1.y = 0.0f;
        v1.z = 2.3f;
        col.transform.position = v1;

    }


    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Player")
        {



            TransformPosition(col);

        }



    }



    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }


}