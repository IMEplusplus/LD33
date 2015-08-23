using UnityEngine;

public class ZOrder : MonoBehaviour {
	void Update () {
        Vector3 pos = transform.position;
        pos.z = pos.y * 0.01f;
        transform.position = pos;
	}
}
