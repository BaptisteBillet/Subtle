using UnityEngine;
using System.Collections;
using System.Collections.Generic;



/// <summary>
/// The class allow their users to use a Dictionary instead of the Google2U system, who is a bit annoying to use.
/// Moreover, the dictionnaries are sort.
/// </summary>
public class TriDataBase : MonoBehaviour
{
    public Dictionary<string, Theme> m_ThemeDico = new Dictionary<string, Theme>();
  
    //This class is a singleton
    #region Singleton
    static private TriDataBase s_Instance;
    static public TriDataBase instance
    {
        get
        {
            return s_Instance;
        }
    }
    #endregion

    void Awake()
    {
        if (s_Instance == null)
            s_Instance = this;
        //DontDestroyOnLoad(this);
        

        /*
        //Sort all Theme
        #region Themes
        foreach (Google2u.ThemeRow row in Google2u.BOW.Instance.Rows)
        {
            Element m_Element = new Element();

            m_Element.m_Capacity = row._Capacity;
            m_Element.m_Damage = row._Damage;
            m_Element.m_HealthPoint = row._HealthPoint;
            m_Element.m_Regeneration = row._Regeneration;
            m_Element.m_Speed = row._Speed;
            m_Element.m_Vision = row._Vision;

            m_Element.m_CapacityUpgrade = row._CapacityUpgrade;
            m_Element.m_DamageUpgrade = row._DamageUpgrade;
            m_Element.m_HealthPointUpgrade = row._HealthPointUpgrade;
            m_Element.m_RegenerationUpgrade = row._RegenerationUpgrade;
            m_Element.m_SpeedUpgrade = row._SpeedUpgrade;
            m_Element.m_VisionUpgrade = row._VisionUpgrade;

            m_Element.m_Cost = row._Cost;
            m_Element.m_Grade = row._Grade;
            m_Element.m_Rank = row._Rank;

            m_Element.m_Name = row._Name;

            m_BowDico.Add(m_Element.m_Name, m_Element);
        }

   
        #endregion
      */
    }

}