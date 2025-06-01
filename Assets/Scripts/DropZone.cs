using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public string acceptedTag;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;

        if (dropped != null && dropped.tag == acceptedTag)
        {
            dropped.transform.position = transform.position;
            dropped.GetComponent<DraggableItem>().droppedOnCorrectZone = true;

            // Baþarýyý bildir
            GameController.Instance.ItemPlacedCorrectly();
        }
        else
        {
            Debug.Log("Yanlýþ kutu!");
        }

        Debug.Log("Drop iþlemi: " + dropped.name + " > " + acceptedTag);
    }
}

