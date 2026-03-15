using UnityEngine;

public class DiaryCanvasController : MonoBehaviour
{
    private PlayerControllerHandler playerControllerHandler;

    private void Start()
    {
        // CanvasManager'a kaydet
        if (CanvasManager.Instance != null)
        {
            // "DiaryCanvas" ismiyle kaydediyoruz
            CanvasManager.Instance.RegisterCanvas("DiaryCanvas", gameObject);
        }

        // Eðer çocuk objeler varsa ilkini aktif et (Kitap kapaðý vb.)
        if (transform.childCount > 0)
        {
            GameObject firstChild = transform.GetChild(0).gameObject;
            if (!firstChild.activeSelf)
            {
                firstChild.SetActive(true);
            }
        }

        // PlayerControllerHandler referansý yoksa bulmaya çalýþ
        if (playerControllerHandler == null)
        {
            playerControllerHandler = FindObjectOfType<PlayerControllerHandler>();
        }
    }

    public void SetPlayerControllerHandler(PlayerControllerHandler handler)
    {
        playerControllerHandler = handler;
    }

    public void CloseCanvas()
    {
        // 1. CanvasManager üzerinden kapatma iþlemi yap
        // (Bu, fare imlecini gizler, blur'u kapatýr ve oyuncu hareketini açar)
        if (CanvasManager.Instance != null)
        {
            // "CloseAll" yerine direkt "CloseCanvas" çaðýrýyoruz ki isimden bulup kapatsýn.
            CanvasManager.Instance.CloseCanvas("DiaryCanvas");
        }

        // 2. KESÝN ÇÖZÜM: Objeyi manuel olarak da kapat
        // Eðer CanvasManager bir sebepten kapatmazsa, bu satýr %100 kapatýr.
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }

        // 3. Oyuncu kontrolünü garantiye al (CanvasManager yapamazsa diye)
        if (playerControllerHandler != null)
        {
            playerControllerHandler.enabled = true;
        }
    }

    // Butona baðlý olan fonksiyon
    public void DiaryCloseCanvas()
    {
        CloseCanvas();
    }
}