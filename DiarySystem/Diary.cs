using UnityEngine;
public class Diary : Collectable
{
    public string canvasName = "DiaryCanvas"; // Bu canvas'ýn CanvasManager'daki adý
    public override void Collect(Transform collectorHand)
    {
        base.Collect(collectorHand);
        Debug.Log("Günlük envantere eklendi.");
    }
    public override void Drop(Vector3 dropPosition, Quaternion dropRotation)
    {
        base.Drop(dropPosition, dropRotation);
        Debug.Log("Günlük yere býrakýldý.");
    }
    public override void ToggleHighlight(bool status)
    {
     
    }
    public void OpenDiaryCanvas()
    {
        // Doðrudan CanvasManager'ý kullanarak canvas'ý aç
        CanvasManager.Instance.OpenCanvas(canvasName);
        Debug.Log("Günlük açýldý.");
    }
}