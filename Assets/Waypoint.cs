﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waypoint : MonoBehaviour
{
    public Image img;
    public Transform target;
    public Text distance;
    public Vector3 offset;
    
    void Update()
    {
        float minX = img.GetPixelAdjustedRect().width /1.25f;
        float maxX = Screen.width - minX;

        float minY = img.GetPixelAdjustedRect().height /1.25f;
        float maxY = Screen.height - minY;

        Vector2 post = Camera.main.WorldToScreenPoint(target.position+offset);
        //img.transform.position = Camera.main.WorldToScreenPoint(target.position);
        post.x = Mathf.Clamp(post.x, minX, maxX);
        post.y = Mathf.Clamp(post.y, minY, maxY);
        img.transform.position = post;

        if (Vector3.Dot((target.position - transform.position),transform.forward) < 0)
        {
            if(post.x<Screen.width/2)
            {
                post.x = maxX;
            }
            else
            {
                post.x = minY;
            }
        }
        distance.text = ((int)Vector3.Distance(target.position, transform.position)).ToString()+"m";
    }
}
