using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public PlayerController playerController;
    
    public GameObject _triggeredCollectible;
    public Material _collectibleDefaultMaterial;

    public GameObject winText;

    private int _collectibleCount;

    public void Collected(GameObject triggeredCollectible)
    {
        triggeredCollectible.GetComponent<MeshRenderer>().material.color = Color.green;
        Destroy(triggeredCollectible.GetComponent<BoxCollider>());
        _collectibleCount++;

        if (_collectibleCount == 4)
        {
            Won();
        }
    }

    private void Won()
    {
        Destroy(playerController.gameObject);
        winText.SetActive(true);
        winText.GetComponent<TextMeshProUGUI>().text = "A WINRAR IS YOU";
    }
}
