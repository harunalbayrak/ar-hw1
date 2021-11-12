using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class imageTargetScript0 : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject treeObj1;
    public GameObject treeObj2;
    public GameObject treeObj3;
    public GameObject treeObj4;
    public GameObject treeObj5;
    public GameObject treeObj6;
    public GameObject treeObj7;
    public GameObject treeObj8;
    public GameObject treeObj9;
    public GameObject treeObj10;
    public GameObject treeObj11;
    public GameObject treeObj12;
    public GameObject treeObj13;
    public GameObject treeObj14;
    public VirtualButtonBehaviour vb;
    public VirtualButtonBehaviour vb2;

    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);

        vb2.RegisterOnButtonPressed(OnButtonPressed2);
        vb2.RegisterOnButtonReleased(OnButtonReleased2);

        obj1.SetActive(false);
        obj2.SetActive(false);
        obj3.SetActive(false);
        treeObj1.SetActive(false);
        treeObj2.SetActive(false);
        treeObj3.SetActive(false);
        treeObj4.SetActive(false);
        treeObj5.SetActive(false);
        treeObj6.SetActive(false);
        treeObj7.SetActive(false);
        treeObj8.SetActive(false);
        treeObj9.SetActive(false);
        treeObj10.SetActive(false);
        treeObj11.SetActive(false);
        treeObj12.SetActive(false);
        treeObj13.SetActive(false);
        treeObj14.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        obj1.SetActive(true);
        obj2.SetActive(true);
        obj3.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        obj1.SetActive(false);
        obj2.SetActive(false);
        obj3.SetActive(false);
    }

    public void OnButtonPressed2(VirtualButtonBehaviour vb2)
    {
        treeObj1.SetActive(true);
        treeObj2.SetActive(true);
        treeObj3.SetActive(true);
        treeObj4.SetActive(true);
        treeObj5.SetActive(true);
        treeObj6.SetActive(true);
        treeObj7.SetActive(true);
        treeObj8.SetActive(true);
        treeObj9.SetActive(true);
        treeObj10.SetActive(true);
        treeObj11.SetActive(true);
        treeObj12.SetActive(true);
        treeObj13.SetActive(true);
        treeObj14.SetActive(true);
    }

    public void OnButtonReleased2(VirtualButtonBehaviour vb2)
    {
        treeObj1.SetActive(false);
        treeObj2.SetActive(false);
        treeObj3.SetActive(false);
        treeObj4.SetActive(false);
        treeObj5.SetActive(false);
        treeObj6.SetActive(false);
        treeObj7.SetActive(false);
        treeObj8.SetActive(false);
        treeObj9.SetActive(false);
        treeObj10.SetActive(false);
        treeObj11.SetActive(false);
        treeObj12.SetActive(false);
        treeObj13.SetActive(false);
        treeObj14.SetActive(false);
    }
}
