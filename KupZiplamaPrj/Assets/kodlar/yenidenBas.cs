using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yenidenBas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (transform.position.y < -7f)
        {
            Olme();
        }
    }
    void Olme()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    private static int GetLoadedLevel()
    {
        return Application.loadedLevel;
    }
}
