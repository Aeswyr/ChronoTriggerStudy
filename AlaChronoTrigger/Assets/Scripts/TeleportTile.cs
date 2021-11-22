using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class TeleportTile : MonoBehaviour
{
    [SerializeField] private Vector2Int destination;


    void OnTriggerEnter2D(Collider2D col)
    {
        col.transform.parent.position = transform.parent.GetComponent<GridLayout>().CellToWorld((Vector3Int)destination) + col.transform.parent.position.z * Vector3.forward + new Vector3(.5f, .5f, 0f);
    }
}
