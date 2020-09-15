using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void Start()
    {
        Destroy (gameObject, 2f);
    }
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
		if(col.CompareTag("Player")){
			Debug.Log("Player Gets Shot, damage -1");
		}
        if(col.CompareTag("Enemies")){
			Debug.Log("Enemy Gets Shot");
		}
	}
}
