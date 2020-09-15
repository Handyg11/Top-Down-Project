using UnityEngine;
using System.Linq;

public class ColorOnHover : MonoBehaviour {

	public Color color;
	public Renderer meshRenderer;

	Color[] originalColours;

	void Start() {
		if (meshRenderer == null) {
			meshRenderer = GetComponent<MeshRenderer> ();
		}
		originalColours = meshRenderer.materials.Select (x => x.color).ToArray ();
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.CompareTag("Player")){
			foreach (Material mat in meshRenderer.materials) {
			mat.color *= color;
			}
		}
	}

	void OnTriggerExit(Collider col)
	{
		if(col.CompareTag("Player")){
			for (int i = 0; i < originalColours.Length; i++) {
				meshRenderer.materials [i].color = originalColours [i];
			}
		}
	}

}
