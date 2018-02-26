using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyTochTriggerDemo : MonoBehaviour {

	public void PrintMsg(GameObject go)
    {
        if(go==null)
        {
            Debug.Log("Null");
        }
        else
        {
            Debug.Log(go.name);
        }
    }
    public void PrintOk()
    {
        Debug.Log("OK");
            
    }
    public void PrintInfo()
    {
        Debug.Log(gameObject.name + "!");
    }

}
