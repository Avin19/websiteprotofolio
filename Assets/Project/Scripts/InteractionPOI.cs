using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPOI : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Panel.SetActive(true);

    }
}
