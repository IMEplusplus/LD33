using UnityEngine;
using System.Collections;

public class DestroyInside : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
    }
}
