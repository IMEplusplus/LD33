using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject player;
    void Update() {
        transform.position = player.transform.position + Vector3.back;
    }
}
