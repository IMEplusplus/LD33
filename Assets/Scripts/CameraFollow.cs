using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject player;
    public float delta;
    public float xMin, xMax;
    void Update() {
        float x = Mathf.Clamp(transform.position.x, player.transform.position.x - delta, player.transform.position.x + delta);
        x = Mathf.Clamp(x, xMin, xMax);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
