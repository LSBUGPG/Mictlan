﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Povs : MonoBehaviour
{
    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        Vector3 currentAngle = new Vector3(Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
                               Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
                               Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;

    }
    public void click1()
    {
        currentView = views[0];
    }

}
