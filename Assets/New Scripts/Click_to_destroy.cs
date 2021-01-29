using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click_to_destroy : MonoBehaviour
{
    public GameObject book_infobox;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Destroy(book_infobox);
        Destroy(gameObject);
    }
}
