using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject player;
    public float delta;
    void Update() {
        float x = Mathf.Clamp(transform.position.x, player.transform.position.x - delta, player.transform.position.x + delta);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
