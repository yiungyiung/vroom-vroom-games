using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cahngecrilcrtoed : MonoBehaviour
{
    private void Awake() {
        PolygonCollider2D poly = GetComponent<PolygonCollider2D>();
        if(poly == null){
            poly = gameObject.AddComponent<PolygonCollider2D>();
        }
        Vector2[] points = poly.points;
        EdgeCollider2D edge = gameObject.AddComponent<EdgeCollider2D>();
        edge.points = points;
        edge.edgeRadius=1;;
        Destroy(poly);
    }
}
