using UnityEngine;
using System.Collections.Generic;

public class Rewind : MonoBehaviour {
    public struct Info {
        public float time;
        public Vector3 position;
    }

    public List<Info> infos;

	void Start () {
        infos = new List<Info>();
	}
	
	void Update () {
        Info info = new Info();
        info.time = Time.realtimeSinceStartup;
        info.position = transform.position;

        infos.Add(info);
	}
}
