using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionController : MonoBehaviour
{
    public string _tagTargetDetection = "Player"; //Selecionar o objeto com a tag player

    public List<Collider2D> detectedObjs = new List<Collider2D>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == _tagTargetDetection)
        {
            detectedObjs.Add(collision);//Entrou na area do Collider
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == _tagTargetDetection)
        {
            detectedObjs.Remove(collision);//Saiu na area do Collider
        }
    }
}
