using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelLine : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float theEnd = 700f;

    private void Update()
    {
        transform.position += new Vector3 (0f, moveSpeed * Time.deltaTime, 0f);
        //Debug.Log(transform.position);

        if(GetComponent<RectTransform>().localPosition.y >= theEnd)
        {
            ButtonOption[] allChildren = GetComponentsInChildren<ButtonOption>(false);
            //Debug.Log(allChildren.Length);
            Destroy(gameObject);
        }
    }
}
