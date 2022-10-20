using UnityEngine;

public class ColorManager : ColorManagerHeritage
{
public void NeutralColor(Square s)              
    { 
        try { s.GetComponent<SpriteRenderer>().color = colorMStratMap.neutralColor; } catch { } 
    }
public void HoveredColor(Square s)              
    { 
        try { s.GetComponent<SpriteRenderer>().color = colorMStratMap.hoveredColor; }catch { } 
    }
public void SelectedColor(Square s)             
    { 
        try { s.GetComponent<SpriteRenderer>().color = colorMStratMap.selectedColor; }catch { } 
    }
public void SelectedCommandantColor(Square s)   
    { 
        try { s.GetComponent<SpriteRenderer>().color = colorMStratMap.selectedCommandantColor; }catch { } 
    }
public void ActionColor(Square s)               
    { 
        try { s.GetComponent<SpriteRenderer>().color = colorMStratMap.actionColor; }catch { } 
    }
}
