using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class GarageColorPicker : MonoBehaviour
{
    //https://www.youtube.com/watch?v=cY2cHP8rnPk
    public UnityEngine.Color output;

    public void OnPointerClick(PointerEventData eventData)
    {
        output = Pick(UnityEngine.Camera.main.WorldToScreenPoint(eventData.position), GetComponent<Image>());
    }

    UnityEngine.Color Pick(Vector2 screenPoint, Image imageToPick)
    {
        Vector2 point;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(imageToPick.rectTransform, screenPoint, Camera.main, out point);
        point += imageToPick.rectTransform.sizeDelta / 2;
        Texture2D t = GetComponent<Image>().sprite.texture;
        Vector2Int m_point = new Vector2Int((int)((t.width * point.x) / imageToPick.rectTransform.sizeDelta.x), (int)((t.height * point.y) / imageToPick.rectTransform.sizeDelta.y));
        return t.GetPixel(m_point.x, m_point.y);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
