using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeout : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
	{
		Invoke("Destroy", 10f);
	
	}
    
	void Destroy()
	{
		Destroy(gameObject);
	}


}
