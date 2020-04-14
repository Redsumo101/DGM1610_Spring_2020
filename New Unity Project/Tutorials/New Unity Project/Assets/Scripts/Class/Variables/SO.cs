using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New SO", menuName ="Scriptable Object")]

public class SO : ScriptableObject
{
    public string fullName;

    public string description;

    public GameObject model;

    public Color color;
}
