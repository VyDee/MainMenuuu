using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DropDown : MonoBehaviour
{
    List<string> names = new List<string>() { "Please choose an options","A", "B", "C", "D" };
    List<string> description = new List<string>()
    {"",
        
        "Spent 24 hours I need more hours with " +
        "you You spent the weekend Getting even, " +
        "ooh oohWe spent the late nightsMaking " +
        "things right, between us now its all good baby" +
        "Roll that Backwood babyAnd play me close", "hello", "how are you", "fine"
    };

    public Dropdown dropdown;
    public Text selectName;

    public void Dropdown_IndexChanged(int index)
    {
        selectName.text = names[index] + " : " + description[index];
    }

    private void Start()
    {
        PopulateList();
    }

    void PopulateList()
    { 
        dropdown.AddOptions(names);
    }





}