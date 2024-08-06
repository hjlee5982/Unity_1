using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Managers.Resource.LoadAllAsync<Object>("PreLoad", (key,count,totalcount)=>
        {
            Debug.Log($"{key} {count}/{totalcount}");

            if(count == totalcount)
            {

            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
