using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    public Dropdown dropDown;


    private void Start()
    {

        PopulateList();
    }


    void PopulateList()
    {
        //TODO: Read these values from the web site

        List<string> names = new List<string>()
        {"Fred", "Barney", "Wilman","Betty"};

        dropDown.AddOptions(names);
    }
}
