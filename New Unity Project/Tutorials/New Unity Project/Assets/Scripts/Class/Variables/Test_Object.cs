using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Object : MonoBehaviour
{
    public SO data;

    private GameObject model;
    // Start is called before the first frame update
    void Start()
    {
        model = data.model;

        var modelRend = model.GetComponent<Renderer>();
        modelRend.sharedMaterial.SetColor("_Color", data.color);

        print(data.name);
        print(data.description);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
