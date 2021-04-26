using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
   public class thewinner
    {
        
       
        public thewinner(string A1, string A2, string A3,string A4,string A5,bool A11, string B1,string B2,string B3,string B4,string B5, bool B11,string C1, string C2,string C3,string C4,string C5,bool C11,string D1,string D2,string D3,string D4,string D5,bool D11,string E1,string E2,string E3,string E4,string E5,bool E11,bool A22,bool A33,bool A44,bool A55,bool winnerfound,bool turn,int sum)
        {
             string winneris="";
            if ((A1 == A2) && (A2 == A3) && (A3 == A4) && (A4 == A5) && (A11 == false))
            {
                winnerfound = true;
                if (turn)
                {
                    winneris = "X";


                }
                else
                {
                    winneris = "O";

                }

            }
            else if ((B1 == B2) && (B2 == B3) && (B3 == B4) && (B4 == B5) && (B11 == false))
            {
                if (turn)
                {
                    winneris = "X";

                }
                else
                {
                    winneris = "O";
                }
                winnerfound = true;

            }
            else if ((C1 == C2) && (C2 == C3) && (C3 == C4) && (C4 == C5) && (C11 == false))
            {
                if (turn)
                {
                    winneris = "X";

                }
                else
                {
                    winneris = "O";
                }
                winnerfound = true;
            }
            else if ((D1 == D2) && (D2 == D3) && (D3 == D4) && (D4 == D5) && (D11 == false))
            {
                if (turn)
                {
                    winneris = "X";

                }
                else
                {

                    winneris = "O";
                }
                winnerfound = true;
            }
            else if ((E1 == E2) && (E2 == E3) && (E3 == E4) && (E4 == E5) && (E11 == false))
            {
                if (turn)
                {
                    winneris = "X";

                }
                else
                {

                    winneris = "O";
                }
                winnerfound = true;
            }

            //όλες οι κατακόρυφες περιπτώσεις
            if ((A1 == B1) && (B1 == C1) && (C1 == D1) && (D1 == E1) && (A11 == false))
            {
                if (turn)
                {
                    winneris = "X";
                }
                else
                {
                    winneris = "O";
                }
                winnerfound = true;
            }
            else if ((A2 == B2) && (B2 == C2) && (C2 == D2) && (D2 == E2) && (A22 == false))
            {
                if (turn)
                {
                    winneris = "X";
                }
                else
                {
                    winneris = "O";
                }
                winnerfound = true;
            }
            else if ((A3 == B3) && (B3 == C3) && (C3 == D3) && (D3 == E3) && (A33 == false))
            {
                if (turn)
                {
                    winneris = "X";
                }
                else
                {
                    winneris = "O";
                }
                winnerfound = true;
            }
            else if ((A4 == B4) && (B4 == C4) && (C4 == D4) && (D4 == E4) && (A44 == false))
            {
                if (turn)
                {
                    winneris = "X";
                }
                else
                {
                    winneris = "O";
                }
                winnerfound = true;
            }
            else if ((A5 == B5) && (B5 == C5) && (C5 == D5) && (D5 == E5) && (A55 == false))
            {
                if (turn)
                {
                    winneris = "X";
                }
                else
                {
                    winneris = "O";
                }
                winnerfound = true;
            }

            //κύρια και δευτερεύουσα διαγώνιος
            if ((A1 == B2) && (B2 == C3) && (C3 == D4) && (D4 == E5) && (A11 == false))
            {
                if (turn)
                {
                    winneris = "X";
                }
                else
                {
                    winneris = "O";
                }
                winnerfound = true;
            }
            if ((A5 == B4) && (B4 == C3) && (C3 == D2) && (D2 == E1) && (A55 == false))
            {
                if (turn)
                {
                    winneris = "X";
                }
                else
                {
                    winneris = "O";
                }
                winnerfound = true;
            }





            if (winnerfound == true)
            {

                
                MessageBox.Show("The winner is " + winneris + Environment.NewLine + "This is the end " + Environment.NewLine+"Goodbye" , "We have a winner",MessageBoxButtons.OK );
                winneris = "";
                Application.Exit();
                
            }







            if ((sum == 25) && (winnerfound == false))
            {              //περίπτωση ισοπαλίας
                MessageBox.Show("It's a draw" + Environment.NewLine + "This is the end" + Environment.NewLine + "Goodbye","Losers" ,MessageBoxButtons.OK);
                Application.Exit();
            }

        }
    }
}
