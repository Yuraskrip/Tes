using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;
    
    
    // Start is called before the first frame update
   public void Start()
    {
        Canvas.SetActive(false);
    }

    public void Interact()
    {
        Canvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
            
    }
}
