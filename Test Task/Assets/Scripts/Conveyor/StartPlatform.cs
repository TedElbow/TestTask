using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPlatform : MonoBehaviour
{
    [SerializeField] private Tray _tray;
    [SerializeField] private Transform _SpawnPosition;
   

    private void Start()
    {
        
        Instantiate(_tray, _SpawnPosition.position, Quaternion.identity);
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tray"))
        {
           
            Instantiate(_tray, _SpawnPosition.position, Quaternion.identity);
         
            
        }
       
    }
}
