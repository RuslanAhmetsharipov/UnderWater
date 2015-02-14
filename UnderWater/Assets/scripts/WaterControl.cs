using UnityEngine;
using System.Collections;

public class WaterControl : MonoBehaviour
{

    public Light light;
    private bool watCon = true;
    public DepthOfFieldScatter dfs;
    void Start()
    {

    }

    void OnTriggerEnter(Collider oth)
    {
        if (oth.tag == "Water")
        {
            if (watCon)
            {
                RenderSettings.fog = false;
                watCon = false;
                light.enabled = false;
                dfs.enabled = false;
            }
            else
                if (!watCon)
                {
                    RenderSettings.fog = true;
                    watCon = true;
                    light.enabled = true;
                    dfs.enabled = true;
                }
        }
    }

    void OnTriggerExit(Collider oth)
    {
        if (oth.tag == "Water")
            if (oth.transform.position.y >= this.transform.position.y)
            {
                watCon = true;
                RenderSettings.fog = true;
            }
            else
            {
                watCon = false;
                RenderSettings.fog = false;
            }

    }
}
