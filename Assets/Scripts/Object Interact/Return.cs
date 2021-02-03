using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
    [SerializeField]
    private bool objectUse = false;

    [SerializeField]
    private GameObject currentObject;

    private Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = currentObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        objectUse = currentObject.GetComponent<DragObject>().getObjectUse();

        if(!objectUse)
        {
            currentObject.transform.position = originalPos;
        }
        
        
    }
}
