using UnityEngine;
using System.Collections;

public partial class GameSystem : MonoBehaviour {

    #region NumberOfPlayer
    public void NumberOfPlayerButtonPressed(bool addbutton)
    {
        if (addbutton)
        {
            m_NumberOfPlayers++;

        }
        else
        {
            m_NumberOfPlayers--;

        }

        NumberOfPlayerVerification();

        m_UIManager.UINumberOfPlayerChangeNumberOfPlayer(m_NumberOfPlayers);

    }

    private void NumberOfPlayerVerification()
    {
        if (m_NumberOfPlayers >= m_NUMBEROFPLAYERSMAXIMUM)
        {
            m_NumberOfPlayers = m_NUMBEROFPLAYERSMAXIMUM;
            m_UIManager.UINumberOfPlayerAppearDisapear(true, false);
        }
        else
        {
            m_UIManager.UINumberOfPlayerAppearDisapear(true, true);
            m_UIManager.UINumberOfPlayerAppearDisapear(false, true);

            if (m_NumberOfPlayers <= m_NUMBEROFPLAYERSMINIMUM)
            {
                m_NumberOfPlayers = m_NUMBEROFPLAYERSMINIMUM;
                m_UIManager.UINumberOfPlayerAppearDisapear(false, false);
            }
            else
            {
                m_UIManager.UINumberOfPlayerAppearDisapear(true, true);
                m_UIManager.UINumberOfPlayerAppearDisapear(false, true);
            }

        }


    }
    #endregion


}
