using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public bool nextLevel;
    public int indexLevel;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.End))
        {
            LevelChange(indexLevel);
        }
        if (nextLevel)
        {
            LevelChange(indexLevel);
        }
        
    }

    public void LevelChange (int index)
    {
        SceneManager.LoadScene(index);
    }
}
