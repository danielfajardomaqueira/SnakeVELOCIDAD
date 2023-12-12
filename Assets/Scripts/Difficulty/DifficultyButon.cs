using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButon : MonoBehaviour
{


    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(DifficultySelected);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DifficultySelected()
    {
        Debug.Log("Button is pressed " + gameObject.name);
    }
}
