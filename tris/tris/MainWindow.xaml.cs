using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tris
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int cont = 1;
        string x = "X";
        string o = "O";
        int[,] matrice = new int[3, 3];
        void turno()
        {
            if (cont % 2 == 0)
            {
                txt_nome1.IsEnabled = false;
                txt_nome2.IsEnabled = false;
                turn.Content = "E' il turno di " + x + "!";
                cont++;
            }
            else
            {
                txt_nome1.IsEnabled = false;
                txt_nome2.IsEnabled = false;
                turn.Content = "E' il turno di " + o + "!";
                cont++;
            }
        }
        void pareggio()
        {
            if (cont==10)
            {
                turn.Content = "La partita è terminata in pareggio!";
            }
        }
        void fine()
        {
          
            System.Threading.Thread.Sleep(300);
            a.IsEnabled = false;
            b.IsEnabled = false;
            c.IsEnabled = false;
            d.IsEnabled = false;
            z.IsEnabled = false;
            f.IsEnabled = false;
            g.IsEnabled = false;
            h.IsEnabled = false;
            i.IsEnabled = false;
        }
        private void combination()
        {
            pareggio();
            if (matrice[0,0] == 10 && matrice[0,1] == 10 && matrice[0,2]==10)
            {
                turn.Content = "il giocatore " + x + " ha vinto";
                fine();
            } else if (matrice[0,0] == 1 && matrice[0,1] == 1 && matrice[0,2] ==1)
            {
                turn.Content = "il giocatore " + o + " ha vinto";
                fine();
            }
            if (matrice[1, 0] == 10 && matrice[1, 1] == 10 && matrice[1, 2] == 10)
            {
                turn.Content = "il giocatore " + x + " ha vinto";
                fine();
            }
            else if (matrice[1, 0] == 1 && matrice[1, 1] == 1 && matrice[1, 2] == 1)    //righe orizzontali
            {
                turn.Content = "il giocatore " + o + " ha vinto";
                fine();
            }
            if (matrice[2, 0] == 10 && matrice[2, 1] == 10 && matrice[2, 2] == 10)
            {
                turn.Content = "il giocatore " + x + " ha vinto";
                fine();
            }
            else if (matrice[2, 0] == 1 && matrice[2, 1] == 1 && matrice[2, 2] == 1)
            {
                turn.Content = "il giocatore " + o + " ha vinto";
                fine();
            }


            if (matrice[0, 0] == 10 && matrice[1, 0] == 10 && matrice[2, 0] == 10)
            {
                turn.Content = "il giocatore " + x + " ha vinto";
                fine();
            }
            else if (matrice[0, 0] == 1 && matrice[1, 0] == 1 && matrice[2, 0] == 1)
            {
                turn.Content = "il giocatore " + o + " ha vinto";
                fine();
            }
            if (matrice[0, 1] == 10 && matrice[1, 1] == 10 && matrice[2, 1] == 10)
            {
                turn.Content = "il giocatore " + x + " ha vinto";
                fine();
            }
            else if (matrice[0, 1] == 1 && matrice[1, 1] == 1 && matrice[2, 1] == 1)    //righe verticali
            {
                turn.Content = "il giocatore " + o + " ha vinto";
                fine();
            }
            if (matrice[0, 2] == 10 && matrice[1, 2] == 10 && matrice[2, 2] == 10)
            {
                turn.Content = "il giocatore " + x + " ha vinto";
                fine();
            }
            else if (matrice[0, 2] == 1 && matrice[1, 2] == 1 && matrice[2, 2] == 1)
            {
                turn.Content = "il giocatore " + o + " ha vinto";
                fine();
            }


            if (matrice[0, 0] == 10 && matrice[1, 1] == 10 && matrice[2, 2] == 10)
            {
                turn.Content = "il giocatore " + x + " ha vinto";
                fine();
            }
            else if (matrice[0, 0] == 1 && matrice[1, 1] == 1 && matrice[2, 2] == 1)    //righe oblique
            {
                turn.Content = "il giocatore " + o + " ha vinto";
                fine();
            }
            if (matrice[0, 2] == 10 && matrice[1, 1] == 10 && matrice[2, 0] == 10)
            {
                turn.Content = "il giocatore " + x + " ha vinto";
                fine();
            }
            else if (matrice[0, 2] == 1 && matrice[1, 1] == 1 && matrice[2, 0] == 1)
            {
                turn.Content = "il giocatore " + o + " ha vinto";
                fine();
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            turno();
            if (cont % 2 == 0)
            {
                a.Content = "x";
                matrice[0, 0] = 10;
                a.IsEnabled = false;
            }
            else
            {
                a.Content = "o";
                matrice[0, 0] = 1;
                a.IsEnabled = false;
            }
            combination();
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             turno();
            if (cont % 2 == 0)
            {

                b.Content = "x";
                matrice[0, 1] = 10;
               b.IsEnabled = false;
            }
            else
            {
                b.Content = "o";
                matrice[0, 1] = 1;
                b.IsEnabled = false;
            }         
            combination();
            
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            turno();
            if (cont % 2 == 0)
            {
                c.Content = "x"; 
                matrice[0, 2] = 10;
                c.IsEnabled = false;
            }
            else
            {
                c.Content = "o";
                matrice[0, 2] = 1;
                c.IsEnabled = false;
            }        
            combination();
          
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            turno();
            if (cont % 2 == 0)
            {
                d.Content = "x";
                matrice[1, 0] = 10;
                d.IsEnabled = false;
            }
            else
            {
                d.Content = "o";    
                matrice[1, 0] = 1;
                d.IsEnabled = false;
            }
            combination();
          
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            turno();
            if (cont % 2 == 0)
            {
                z.Content = "x";             
                matrice[1, 1] = 10;
                z.IsEnabled = false;
            }
            else
            {
                z.Content = "o";              
                matrice[1, 1] = 1;
                z.IsEnabled = false;
            }
            combination();
           
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            turno();
            if (cont % 2 == 0)
            {
                f.Content = "x";              
                matrice[1, 2] = 10;
                f.IsEnabled = false;
            }
            else
            {
                f.Content = "o";              
                matrice[1, 2] = 1;
                f.IsEnabled = false;
            }
            combination();
           
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            turno();
            if (cont % 2 == 0)
            {
                g.Content = "x";        
                matrice[2, 0] = 10;
                g.IsEnabled = false;
            }
            else
            {
                g.Content = "o";
                matrice[2, 0] = 1;
                g.IsEnabled = false;
            }
            combination();
          
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            turno();
            if (cont % 2 == 0)
            {
                h.Content = "x";            
                matrice[2, 1] = 10;
                h.IsEnabled = false;
            }
            else
            {
                h.Content = "o";             
                matrice[2, 1] = 1;
                h.IsEnabled = false;
            }
            combination();
       
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            turno();
            if (cont % 2 == 0)
            {
                i.Content = "x";            
                matrice[2, 2] =10;
                i.IsEnabled = false;
            }
            else
            {
                i.Content = "o";            
                matrice[2, 2] = 1;
                i.IsEnabled = false;
            }
            combination();
        
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            a.IsEnabled = true;
            b.IsEnabled = true;
            c.IsEnabled = true;
            d.IsEnabled = true;
            z.IsEnabled = true;
            f.IsEnabled = true;
            g.IsEnabled = true;
            h.IsEnabled = true;
            i.IsEnabled = true;
            a.Content = "";
            b.Content = "";
            c.Content = "";
            d.Content = "";
            z.Content = "";
            f.Content = "";
            g.Content = "";
            h.Content = "";
            i.Content = "";
            matrice[0, 0] = 0;
            matrice[1, 0] = 0;
            matrice[2, 0] = 0;
            matrice[0, 1] = 0;
            matrice[0, 2] = 0;
            matrice[1, 1] = 0;
            matrice[2, 2] = 0;
            matrice[1, 2] = 0;
            matrice[2, 1] = 0;
            txt_nome1.Text = "";
            txt_nome2.Text = "";
            cont = 1;
            txt_nome1.IsEnabled = true;
            txt_nome2.IsEnabled = true;
            turn.Content = "Fai tris per vincere!";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            x = txt_nome1.Text;
            if (x=="")
            {
                x = "X";
            }

        }
        private void txt_nome2_TextChanged(object sender, TextChangedEventArgs e)
        {
            o = txt_nome2.Text;
            if (o=="")
            {
                o = "O";
            }
        }
    }
}
