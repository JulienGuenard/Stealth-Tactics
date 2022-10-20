using UnityEngine;

public class ColorManager : ColorManagerHeritage
{
public void NeutralColor(Square s)              { s.GetComponent<SpriteRenderer>().color = colorMStratMap.neutralColor; }
public void HoveredColor(Square s)              { s.GetComponent<SpriteRenderer>().color = colorMStratMap.hoveredColor; }
public void SelectedColor(Square s)             { s.GetComponent<SpriteRenderer>().color = colorMStratMap.selectedColor; }
public void SelectedCommandantColor(Square s)   { s.GetComponent<SpriteRenderer>().color = colorMStratMap.selectedCommandantColor; }
public void ActionColor(Square s)               { s.GetComponent<SpriteRenderer>().color = colorMStratMap.actionColor; }

}
