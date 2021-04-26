using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        bool turn = true; // ξεκινάει πάντα ο Χ
        int sum = 0;//ο αριθμός των γύρων για την ισοπαλία
        bool winnerfound=false;//δεν έχει βρεθεί ο νικητής
        bool select = false; // για τον υπολογιστή
        public class reset 
        {                                    
            public reset(Button newgame) // για το νέο παιχνίδι
            {              
                newgame.Enabled = true;
                newgame.Text = "";
            }
        }

                            
        
       
         
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

        }

        private void button_click(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender; // για τον έλεγχο των κουμπιών
            
           if (turn)
            {
                ClickedButton.Text = "X";       
            }             
            else
            {
                ClickedButton.Text = "O";
            }

            
            ClickedButton.Enabled = false;
            sum++;// μετρητής των κινήσεων
            
            thewinner win = new thewinner(A1.Text,A2.Text,A3.Text,A4.Text,A5.Text,A1.Enabled,B1.Text,B2.Text,B3.Text,B4.Text,B5.Text,B1.Enabled,C1.Text,C2.Text,C3.Text,C4.Text,C5.Text,C1.Enabled,D1.Text,D2.Text,D3.Text,D4.Text,D5.Text,D1.Enabled,E1.Text,E2.Text,E3.Text,E4.Text,E5.Text,E1.Enabled,A2.Enabled,A3.Enabled,A4.Enabled,A5.Enabled,winnerfound,turn,sum);

            turn = !turn;// κάθε φορά που γίνεται μία κίνηση αλλάζει η σειρά του παίκτη
            
            
            
                if ((turn == false) && (select))
                {
                    List<Control> available = new List<Control>();
                    foreach (Control c in Controls)
                    {
                        try
                        {
                            Button b = (Button)c;
                            if (b.Enabled)
                                available.Add(c);

                        }
                        catch { }
                    }
                    if (available.Count == 0)
                    {
                        return;
                    }

                    Random r = new Random();
                    Control used = available[r.Next(0, available.Count)];

                    Button b2 = (Button)used;
                    b2.Text = "O";
                    b2.Enabled = false;
                    sum++;
                    thewinner win1 = new thewinner(A1.Text, A2.Text, A3.Text, A4.Text, A5.Text, A1.Enabled, B1.Text, B2.Text, B3.Text, B4.Text, B5.Text, B1.Enabled, C1.Text, C2.Text, C3.Text, C4.Text, C5.Text, C1.Enabled, D1.Text, D2.Text, D3.Text, D4.Text, D5.Text, D1.Enabled, E1.Text, E2.Text, E3.Text, E4.Text, E5.Text, E1.Enabled, A2.Enabled, A3.Enabled, A4.Enabled, A5.Enabled, winnerfound, turn, sum);
                    turn = !turn;
                    

                }
            
           


              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //για τα 25 κουμπιά
            reset resetall1 = new reset(A1);
            reset resetall2 = new reset(A2);
            reset resetall3 = new reset(A3);
            reset resetall4 = new reset(A4);
            reset resetall5 = new reset(A5);
            reset resetall6 = new reset(B1);
            reset resetall7= new reset(B2);
            reset resetall8 = new reset(B3);
            reset resetall9 = new reset(B4);
            reset resetall10 = new reset(B5);
            reset resetall11 = new reset(C1);
            reset resetall12 = new reset(C2);
            reset resetall13 = new reset(C3);
            reset resetall14 = new reset(C4);
            reset resetall15 = new reset(C5);
            reset resetall16 = new reset(D1);
            reset resetall17= new reset(D2);
            reset resetall18 = new reset(D3);
            reset resetall19 = new reset(D4);
            reset resetall20 = new reset(D5);
            reset resetall21 = new reset(E1);
            reset resetall22 = new reset(E2);
            reset resetall23 = new reset(E3);
            reset resetall24 = new reset(E4);
            reset resetall25 = new reset(E5);
            sum = 0; //μηδενίζω τον μετρητή για το νέο παιχνίδι
            turn = true; // Ξεκινάει πάντα ο Χ
            
            




        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic-Tac-Toe: game of 5x5");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void cPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select = true;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
