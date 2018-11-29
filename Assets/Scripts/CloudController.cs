using UnityEngine;

public class CloudController : MonoBehaviour{
    public void inForeground()
    {
        GetComponent<SpriteRenderer>().sortingLayerName = "foreground";
    }

    public void InBackground()
    {
        GetComponent<SpriteRenderer>().sortingLayerName = "background";
    }
}