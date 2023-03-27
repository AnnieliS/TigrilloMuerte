using UnityEngine;

public class SpriteRendererOrderSystem : MonoBehaviour
{
private void Update() {
    SpriteRenderer[] renderers = FindObjectsOfType<SpriteRenderer>();

    foreach(SpriteRenderer renderer in renderers){
        renderer.sortingOrder = (int)(renderer.transform.position.y * -10);
    }
}
}
