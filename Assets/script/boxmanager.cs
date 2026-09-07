using UnityEngine;
using UnityEngine.UIElements;

public class BoxManager : MonoBehaviour
{
    public GameObject[] boxes;

    public Rotater[] rotaters;

    public float delaytime = 1f;


    private float passeedtime;
    private bool needActivate = true;

    // Update is called once per frame
    void Update()
    {
        passeedtime = passeedtime + Time.deltaTime;

        passeedtime += Time.deltaTime;
        if (passeedtime > delaytime)
        {
            foreach (GameObject go in boxes)
            {
                go.SetActive(true);
            }

            needActivate = false;

        }


    }
}

