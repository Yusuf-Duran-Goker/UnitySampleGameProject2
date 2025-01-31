using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerMoverController : MonoBehaviour
{
    
    Rigidbody2D rb;

      [SerializeField]
      Transform zeminKontrolNoktasi;

      [SerializeField]
      Animator anim;
      
      public LayerMask zeminMaske;

    public float hareketHizi;
    public float ziplamaGucu;
    bool zemindemi;
    bool ikinciKezZiplasinMi;



   private void Awake()
   {
     rb = GetComponent<Rigidbody2D>();
   }
   

    private void Update()
    {
        HareketEt();
        ZiplaFNC();
         anim.SetBool("zemindemi",zemindemi);
         anim.SetFloat("hareketHizi", Mathf.Abs(rb.velocity.x));
    }

    void HareketEt()
    {
       float h =Input.GetAxis("Horizontal");
       rb.velocity = new Vector2(h* hareketHizi, rb.velocity.y);

       if (rb.velocity.x < 0)
       {
        transform.localScale = new Vector3(-1,1,1);
       }
       else if (rb.velocity.x > 0)
       {
        transform.localScale = new Vector3 (1,1,1);// Vector.one da ayni anlama gelir
       }
    }

   void ZiplaFNC()
{
    // Zeminle temas kontrolü
    zemindemi = Physics2D.OverlapCircle(zeminKontrolNoktasi.position, 0.2f, zeminMaske);

    // Zıplama tuşuna basıldıysa ve zemindeysek veya ikinci zıplama hakkı varsa
    if (Input.GetButtonDown("Jump") && (zemindemi || ikinciKezZiplasinMi))
    {
        // Eğer zemindeysek, ikinci zıplama hakkını ver
        if (zemindemi)
        {
            ikinciKezZiplasinMi = true;
        }
        else
        {
            ikinciKezZiplasinMi = false; // İkinci zıplama tamamlandıktan sonra sıfırla
        }

        // Zıplama hareketini uygula
        rb.velocity = new Vector2(rb.velocity.x, ziplamaGucu);
    }

    // Eğer zemine temas edersek ikinci zıplama sıfırlanır
    if (zemindemi)
    {
        ikinciKezZiplasinMi = true; // Zeminle temas tekrar ikinci zıplama hakkı verir
    }

   
}


}
