using UnityEngine;
using System.Collections;

public class Princess : MonoBehaviour {

    Vector3 velocity = new Vector3(6f, 0, 0);

	void Update () {
        transform.position += velocity*Time.deltaTime;
	}
    void OnTriggerExit2D(Collider2D col){
        if (col.gameObject.tag == "MainCamera")
            Destroy(this.gameObject);
    }
}
