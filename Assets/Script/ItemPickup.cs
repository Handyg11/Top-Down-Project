using UnityEngine;

public class ItemPickup : MonoBehaviour {

	public Item item;
	
	void OnTriggerEnter(Collider col){
		if(col.CompareTag("Player")){
			Debug.Log("Interacting");
			PickUp();
		}
	}
	void PickUp ()
	{
			Debug.Log("Picking up " + item.name);
			Inventory.instance.Add(item);
			Destroy(gameObject);
	}

}
