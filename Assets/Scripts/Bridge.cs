using UnityEngine;

public class Bridge : MonoBehaviour {
    Animator anim;
    public AnimationClip beginAnim;

    void Awake() {
        anim = GetComponent<Animator>();
    }

	void Start () {
	}
}
