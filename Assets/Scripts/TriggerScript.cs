using UnityEngine;

public class TriggerScript : MonoBehaviour {
    public delegate void OnTriggerDelegate();
    public OnTriggerDelegate OnTrigger;

    public void Trigger() {
        if (OnTrigger != null)
            OnTrigger();
    }
}
