using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelView : MonoBehaviour
{
    [SerializeField] private GameObject prefabPanelLine;
    [SerializeField] private List<GameObject> prefabsButtonOptions;
    [SerializeField] private float timeBetweenInstantiate = 1.5f;

    private float nextPanelLineInstantiateTime;


    private void Start()
    {
        InstantiatePanelLine();

        nextPanelLineInstantiateTime = Time.time + timeBetweenInstantiate;
    }

    private void Update()
    {
        if (Time.time > nextPanelLineInstantiateTime)
        {
            nextPanelLineInstantiateTime = Time.time + timeBetweenInstantiate;
            InstantiatePanelLine();
        }
    }

    private void InstantiatePanelLine()
    {
        GameObject panelLine = Instantiate(prefabPanelLine, transform);
        for (int i = 0; i < 6; i++)
        {
            int rand = Random.Range(0, prefabsButtonOptions.Count);

            GameObject option = Instantiate(prefabsButtonOptions[rand], panelLine.transform);
        }
    }

}
