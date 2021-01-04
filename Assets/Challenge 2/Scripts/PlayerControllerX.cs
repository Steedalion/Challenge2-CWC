using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
	public GameObject dogPrefab;
	GameObject dog;
	bool pushed = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
	    if (Input.GetKeyDown(KeyCode.Space) && !pushed)
        {
	        dog = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
	        dog.AddComponent<Timeout>();
	        pushed = true;
	        Invoke("PressDelay",1.0f);
        }
    }
	void PressDelay()
	{
		pushed = false;
	}
}
