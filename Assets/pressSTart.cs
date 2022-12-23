using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pressSTart : MonoBehaviour
{
    public ClothSpawner cs;
    public InputField m;
    public InputField sl;
    public InputField ll;
    public Dropdown ins;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public enum IntegrationMethod { EULARIAN, RK2, RK4 };
    public void updateValue()
    {
        cs.mass = float.Parse(m.text);
        cs.resolution = int.Parse(sl.text);

        if (ll.text == "1")
        {
            cs.restrained[1] = 0;
        }
        else
        {
            cs.restrained[1] = cs.resolution;
        }

        cs.method = ins.value;
        

    }
}
