using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DetectCollisionsX : MonoBehaviour
{
	public AudioClip bark;
    private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Dog"))
		{
			AudioSource.PlayClipAtPoint(bark, gameObject.transform.position);
			Destroy(gameObject);
		}
        
    }
}
