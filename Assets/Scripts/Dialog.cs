using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
   public TextMeshProUGUI textDisplay;
   public string[] sentencs;
   private int index;
   public float typingSpeed;

   private void Start()
   {
      StartCoroutine(Type());
   }


   IEnumerator Type()
   {
      foreach (char letter in sentencs[index].ToCharArray())
      {
         textDisplay.text += letter;
         yield return new WaitForSeconds(typingSpeed);
      }
   }

   public void NextSentence()
   {
      if (index < sentencs.Length - 1)
      {
         index++;
         textDisplay.text = "";
         StartCoroutine(Type());
      }
      else
      {
         textDisplay.text = "";
      }
   }
   
}