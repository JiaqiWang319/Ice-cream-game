﻿using UnityEngine;
using System.Collections;

public class ingredientData : MonoBehaviour {
    //define the object of each price card
    GameObject m_obj1;   //+20
    GameObject m_obj2;   //-20
    GameObject m_obj3;   //+10
    GameObject m_obj4;   //-10

    //define the object of each ingredient card
    GameObject ing1;      //strawberryFlavor
    GameObject ing2;      //raspberrySauce
    GameObject ing3;      //vanillaFlavor
    GameObject ing4;      //waferTopping
    GameObject ing5;      //chocolateSauce
    GameObject ing6;      //plainCone
    GameObject ing7;      //sprinkleCone
    GameObject ing8;      //cherryTopping


    //define and intitial the score of each ingredient
    static public int chocolateSauce = 0;    
   static public int raspberrySauce = 0;
    static public int waferTopping = 0;
    static public int cherryTopping = 0;
    static public int plainCone = 0;
    static public int sprinkleCone = 0;
    static public int vanillaFlavor = 0;
    static public int strawberryFlavor = 0;

    //define and intitial the sign of changing the score of each ingredient(with the first character of each ingredient) 
    int choScoreChange = 0;
    int rasScoreChange = 0;
    int wafScoreChange = 0;
    int cheScoreChange = 0;
    int plaScoreChange = 0;
    int sprScoreChange = 0;
    int vanScoreChange = 0;
    int strScoreChange = 0;


    //the size of the ingredient card
    double halfXsize = 1.3;
    double halfYsize = 1.8;




    public void Start()
    {
        //get the position of each price card
        m_obj1 = GameObject.Find("price (1)");
        m_obj2 = GameObject.Find("price (2)");
        m_obj3 = GameObject.Find("price (3)");
        m_obj4 = GameObject.Find("price (4)");

        //get the position of each ingredient card
        ing1 = GameObject.Find("ingredient1");
        ing2 = GameObject.Find("ingredient2");
        ing3 = GameObject.Find("ingredient3");
        ing4 = GameObject.Find("ingredient4");
        ing5 = GameObject.Find("ingredient5");
        ing6 = GameObject.Find("ingredient6");
        ing7 = GameObject.Find("ingredient7");
        ing8 = GameObject.Find("ingredient8");

        reput();
       
    }

	// Update is called once per frame
	void Update () {

        GoOn();
       clear();



    }

   //get the position and call for the position function 
    void GoOn() {
        Vector3 price1_postion = m_obj1.transform.position;
        float x1 = price1_postion.x;
        float y1 = price1_postion.y;
        Vector3 price2_postion = m_obj2.transform.position;
        float x2 = price2_postion.x;
        float y2 = price2_postion.y;
        Vector3 price3_postion = m_obj3.transform.position;
        float x3 = price3_postion.x;
        float y3 = price3_postion.y;
        Vector3 price4_postion = m_obj4.transform.position;
        float x4 = price4_postion.x;
        float y4 = price4_postion.y;

        position(x1, y1,20);
        position(x2, y2,-20);
        position(x3, y3, 10);
        position(x4, y4, -10);

        // show the score of each ingredient at the bottom of the screen
       Debug.Log("strawberryFlavor=" + strawberryFlavor.ToString("f4")
                  + "   raspberrySauce="+raspberrySauce.ToString("f4")
                  + "   vanillaFlavor="+vanillaFlavor.ToString("f4")
                  + "   waferTopping="+ waferTopping.ToString("f4")
                  + "   chocolateSauce="+ chocolateSauce.ToString("f4") 
                  + "   plainCone="+ plainCone.ToString("f4")
                  + "   sprinkleCone=" + sprinkleCone.ToString("f4")
                  + "   cherryTopping="+ cherryTopping.ToString("f4"));
      

    }
    void position(float x,float y,int score)
    {
        //get the position of each ingredient card
        float x1 = ing1.transform.position.x;
        float y1 = ing1.transform.position.y;
        float x2 = ing2.transform.position.x;
        float y2 = ing2.transform.position.y;
        float x3 = ing3.transform.position.x;
        float y3 = ing3.transform.position.y;
        float x4 = ing4.transform.position.x;
        float y4 = ing4.transform.position.y;
        float x5 = ing5.transform.position.x;
        float y5 = ing5.transform.position.y;
        float x6 = ing6.transform.position.x;
        float y6 = ing6.transform.position.y;
        float x7 = ing7.transform.position.x;
        float y7 = ing7.transform.position.y;
        float x8 = ing8.transform.position.x;
        float y8 = ing8.transform.position.y;
        //Give the score to an ingredient 
        if (x > x1-halfXsize && x < x1+halfXsize)            //if the score card is on the strawberryFlavor card?
        {
            if (y > y1-halfYsize && y < y1+halfYsize)
            {
                strawberryFlavor = score;
                strScoreChange = 1;
            }
        }
        if (x > x2 - halfXsize && x < x2 + halfXsize)             //if the score card is on the raspberrySauce card?
        {
            if (y > y2 - halfYsize && y < y2 + halfYsize)
            {
                raspberrySauce = score;
                rasScoreChange = 1;
            }
        }
        if (x > x3 - halfXsize && x < x3 + halfXsize)          //if the score card is on the  vanillaFlavor card?
        {
            if (y > y3 - halfYsize && y < y3 + halfYsize)
            {
                vanillaFlavor = score;
                vanScoreChange = 1;
            }
        }
        if (x > x4 - halfXsize && x < x4 + halfXsize)         //if the score card is on the waferTopping card?
        {
            if (y > y4 - halfYsize && y < y4 + halfYsize)
            {
                waferTopping = score;
                wafScoreChange = 1;
            }
        }
        if (x > x5 - halfXsize && x < x5 + halfXsize)           //if the score card is on the chocolateSauce card?
        {
            if (y > y5 - halfYsize && y < y5 + halfYsize)
            {
                chocolateSauce = score;
                choScoreChange = 1;
            }
        }
        if (x > x6 - halfXsize && x < x6 + halfXsize)            //if the score card is on the plainCone card?
        {
            if (y > y6 - halfYsize && y < y6 + halfYsize)
            {
                plainCone = score;
                plaScoreChange = 1;
            }
        }
        if (x > x7 - halfXsize && x < x7 + halfXsize)            //if the score card is on the sprinkleCone card?
        {
            if (y > y7 - halfYsize && y < y7 + halfYsize)
            {
                sprinkleCone = score;
                sprScoreChange = 1;
            }
        }
        if (x > x8 - halfXsize && x < x8 + halfXsize)            //if the score card is on the cherryTopping card?
        {
            if (y > y8 - halfYsize && y < y8 + halfYsize)
            {
                cherryTopping = score;
                cheScoreChange = 1;
            }
        }

    }

    //when the score card away form the ingredient card, the score of that card is cleared
    void clear() {
        if (strScoreChange == 0)
        {
            strawberryFlavor = 0;
        }
        if (rasScoreChange == 0)
        {
            raspberrySauce = 0;
        }
        if (vanScoreChange == 0)
        {
            vanillaFlavor = 0;
        }
        if (wafScoreChange == 0)
        {
            waferTopping = 0;
        }
        if (choScoreChange == 0)
        {
            chocolateSauce = 0;
        }
        if (plaScoreChange == 0)
        {
            plainCone = 0;
        }
        if (sprScoreChange == 0)
        {
            sprinkleCone = 0;
        }
        if (cheScoreChange == 0)
        {
            cherryTopping = 0;
        }

        //clear the changing sign
        choScoreChange = 0;
        rasScoreChange = 0;
        wafScoreChange = 0;
        cheScoreChange = 0;
        plaScoreChange = 0;
        sprScoreChange = 0;
        vanScoreChange = 0;
        strScoreChange = 0;

    }


    // if the screen comes from the link of Seefridge, then we will remember the former data of the score of the ingredient
    // We use data from the icecreamData scripts
    void reput()
    {
        if (SeeFridge.seefridge == 1)
        {
            if (icecreamData.cherryTopping == 20)                     //cherryTopping
            {
                m_obj1.transform.position = ing8.transform.position;
            }
            if (icecreamData.cherryTopping == -20)
            {
                m_obj2.transform.position = ing8.transform.position;
            }
            if (icecreamData.cherryTopping == 10)
            {
                m_obj3.transform.position = ing8.transform.position;
            }
            if (icecreamData.cherryTopping == -10)
            {
                m_obj4.transform.position = ing8.transform.position;
            }
            if (icecreamData.chocolateSauce == 20)                     //chocolatesauce
            {
                m_obj1.transform.position = ing5.transform.position;
            }
            if (icecreamData.chocolateSauce == -20)
            {
                m_obj2.transform.position = ing5.transform.position;
            }
            if (icecreamData.chocolateSauce == 10)
            {
                m_obj3.transform.position = ing5.transform.position;
            }
            if (icecreamData.chocolateSauce == -10)
            {
                m_obj4.transform.position = ing5.transform.position;
            }
            if (icecreamData.plainCone == 20)                       //plaincone
            {
                m_obj1.transform.position = ing6.transform.position;
            }
            if (icecreamData.plainCone == -20)
            {
                m_obj2.transform.position = ing6.transform.position;
            }
            if (icecreamData.plainCone == 10)
            {
                m_obj3.transform.position = ing6.transform.position;
            }
            if (icecreamData.plainCone == -10)
            {
                m_obj4.transform.position = ing6.transform.position;
            }
            if (icecreamData.sprinkleCone == 20)                        //sprinkle cone
            {
                m_obj1.transform.position = ing7.transform.position;
            }
            if (icecreamData.sprinkleCone == -20)
            {
                m_obj2.transform.position = ing7.transform.position;
            }
            if (icecreamData.sprinkleCone == 10)
            {
                m_obj3.transform.position = ing7.transform.position;
            }
            if (icecreamData.sprinkleCone == -10)
            {
                m_obj4.transform.position = ing7.transform.position;
            }
            if (icecreamData.raspberrySauce == 20)                      //raspberry
            {
                m_obj1.transform.position = ing2.transform.position;
            }
            if (icecreamData.raspberrySauce == -20)
            {
                m_obj2.transform.position = ing2.transform.position;
            }
            if (icecreamData.raspberrySauce == 10)
            {
                m_obj3.transform.position = ing2.transform.position;
            }
            if (icecreamData.raspberrySauce == -10)
            {
                m_obj4.transform.position = ing2.transform.position;
            }
            if (icecreamData.vanillaFlavor == 20)                         //vanillaflavor
            {
                m_obj1.transform.position = ing3.transform.position;
            }
            if (icecreamData.vanillaFlavor == -20)
            {
                m_obj2.transform.position = ing3.transform.position;
            }
            if (icecreamData.vanillaFlavor == 10)
            {
                m_obj3.transform.position = ing3.transform.position;
            }
            if (icecreamData.vanillaFlavor == -10)
            {
                m_obj4.transform.position = ing3.transform.position;
            }
            if (icecreamData.strawberryFlavor == 20)                        //strawberryFlavor
            {
                m_obj1.transform.position = ing1.transform.position;
            }
            if (icecreamData.strawberryFlavor == -20)
            {
                m_obj2.transform.position = ing1.transform.position;
            }
            if (icecreamData.strawberryFlavor == 10)
            {
                m_obj3.transform.position = ing1.transform.position;
            }
            if (icecreamData.strawberryFlavor == -10)
            {
                m_obj4.transform.position = ing1.transform.position;
            }
            if (icecreamData.waferTopping == 20)               //waferTopping  
            {
                m_obj1.transform.position = ing4.transform.position;
            }
            if (icecreamData.waferTopping == -20)
            {
                m_obj2.transform.position = ing4.transform.position;
            }
            if (icecreamData.waferTopping == 10)
            {
                m_obj3.transform.position = ing4.transform.position;
            }
            if (icecreamData.waferTopping == -10)
            {
                m_obj4.transform.position = ing4.transform.position;
            }


        }
    }


}
