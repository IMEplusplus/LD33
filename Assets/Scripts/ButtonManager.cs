using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {

    public GameObject bridge;
    public GameObject bridgeColider;
    public GameObject elfPrefab;
    bool spawned;

    AudioSource audio;

    private bool locked = false;

    void Start()
    {
        GameObject explosion = GameObject.Find("Explosion");
        audio = explosion.GetComponent<AudioSource>();
        spawned = false;
    }

    public void Activate()
    {
        if(!locked)
        {
            audio.Play();
            bridge. SetActive(!bridge.activeSelf);
            bridgeColider.SetActive(!bridgeColider.activeSelf);

            //Monster Spawn
            if (!spawned)
            {
                Instantiate(elfPrefab, transform.position + (Vector3.down) * 3, Quaternion.identity);
                Instantiate(elfPrefab, transform.position + (Vector3.down) * 3 + (Vector3.left) * 2, Quaternion.identity);
                Instantiate(elfPrefab, transform.position + (Vector3.down) * 3 + (Vector3.left) * 4, Quaternion.identity);
                spawned = true;
            }

        }
    }
}
