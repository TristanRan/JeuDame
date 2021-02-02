using ClassDames;
using MainApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDameWinForm
{
    public partial class Form1 : Form
    {

        public enum Turn
        {
            Player1,
            Player2
        }

        public enum Theme
        {
            classic,
            starWars,
            dragonBall,
            dragonBallBoo
        }

        public EventHandler MouvementDone;
        int posX = 0;
        int posY = 0;

        int posXb = 0;
        int posYb = 0;

        Turn currentTurn = Turn.Player1;
        Theme currentTheme;

        Bitmap currentPionBlanc;
        Bitmap currentPionNoir;
        Bitmap currentDameBlanc;
        Bitmap currentDameNoire;

        Bitmap pionBlanc = new Bitmap(Properties.Resources.pionBlanc);
        Bitmap pionNoir = new Bitmap(Properties.Resources.pionNoir);
        Bitmap dameNoire = new Bitmap(Properties.Resources.dameNoire);
        Bitmap dameBlanche = new Bitmap(Properties.Resources.dameBlanche);
       
        Bitmap pionRebelle = new Bitmap(Properties.Resources.pionRebelle);
        Bitmap dameRebelle = new Bitmap(Properties.Resources.dameRebelle);
        Bitmap pionEmpire= new Bitmap(Properties.Resources.pionEmpire);
        Bitmap dameEmpire= new Bitmap(Properties.Resources.dameEmpire);

        Bitmap pionGoku= new Bitmap(Properties.Resources.pionGoku);
        Bitmap dameGoku = new Bitmap(Properties.Resources.dameGoku);
        Bitmap pionVegeta = new Bitmap(Properties.Resources.pionVegeta);
        Bitmap dameVegeta = new Bitmap(Properties.Resources.dameVegeta);

        Bitmap pionGotrunk = new Bitmap(Properties.Resources.pionGotrunks);
        Bitmap dameGotrunk = new Bitmap(Properties.Resources.dameGotrunks);
        Bitmap pionBoo = new Bitmap(Properties.Resources.pionBoo);
        Bitmap dameBoo = new Bitmap(Properties.Resources.dameBoo);

        Damier damier;
        public BtnCase[,] btnGrid;
       

        public Form1()
        {
            InitializeComponent();
            var dialog = new ChoixTheme();
            dialog.ShowDialog();
            if(dialog.selected == "Classique")
            {
                currentTheme = Theme.classic;
            }
            if (dialog.selected == "Star Wars")
            {
                currentTheme = Theme.starWars;
            }
            if(dialog.selected == "Dragon Ball")
            {
                currentTheme = Theme.dragonBall;
            }
            if (dialog.selected == "Dragon Ball Boo")
            {
                currentTheme = Theme.dragonBallBoo;
            }

            selectionnedTheme();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            generateDamier();
            damier = new Damier();
            damier.genererDamierRemplis();
            refreshDamier();
            assignTurn();

            this.damier.PropertyChanged += EndGame;
            this.damier.PropertyChanged += AddDeadPions;
            MouvementDone += ChangeTurn;


        }

        private void ChangeTurn(object sender, EventArgs e)
        {

            if (currentTurn == Turn.Player1)
            {
                currentTurn = Turn.Player2;
            }
            else
            {
                if (currentTurn == Turn.Player2)
                {
                    currentTurn = Turn.Player1;
                }
            }
            assignTurn();

        }

        private void assignTurn()
        {
            if(currentTurn == Turn.Player1)
            {
                labelTurn.Text = "Tour du joueur 1";
                
                foreach(Pieces pieces in damier.tab2D)
                {
                    if(pieces.Currentcolor == Pieces.colorPion.Noir)
                    {
                        btnGrid[pieces.position.X, pieces.position.Y].Enabled = false;
                    }

                    if (pieces.Currentcolor == Pieces.colorPion.Blanc)
                    {
                        btnGrid[pieces.position.X, pieces.position.Y].Enabled = true;
                    }
                }
            }

            if (currentTurn == Turn.Player2)
            {
                labelTurn.Text = "Tour du joueur 2";
               
                foreach (Pieces pieces in damier.tab2D)
                {
                    if (pieces.Currentcolor == Pieces.colorPion.Blanc)
                    {
                        btnGrid[pieces.position.X, pieces.position.Y].Enabled = false;
                    }

                    if (pieces.Currentcolor == Pieces.colorPion.Noir)
                    {
                        btnGrid[pieces.position.X, pieces.position.Y].Enabled = true;
                    }
                }
            }
        }

        private void selectionnedTheme()
        {
            switch (currentTheme)
            {
                case Theme.classic:
                    currentPionBlanc = pionBlanc;
                    currentDameBlanc = dameBlanche;
                    currentPionNoir = pionNoir;
                    currentDameNoire = dameNoire;
                    break;
                case Theme.starWars:
                    currentPionBlanc = pionRebelle;
                    currentDameBlanc = dameRebelle;
                    currentPionNoir = pionEmpire;
                    currentDameNoire = dameEmpire;
                    break;
                case Theme.dragonBall:
                    currentPionBlanc = pionGoku;
                    currentDameBlanc = dameGoku;
                    currentPionNoir = pionVegeta;
                    currentDameNoire = dameVegeta;
                    break;
                case Theme.dragonBallBoo:
                    currentPionBlanc = pionGotrunk;
                    currentDameBlanc = dameGotrunk;
                    currentPionNoir = pionBoo;
                    currentDameNoire = dameBoo;
                    break;
            } 

        }

        private void AddDeadPions(object sender, PropertyChangedEventArgs e)
        {

            if(e.PropertyName == "countPiecesBlanches")
            {
                

                if (panelPriseNoir.Controls.Count % 2 == 0) 
                {
                    
                    PictureBox picture = new PictureBox();
                    picture.Location = new Point(posX, posY);
                    picture.Size = new Size(75, 75);
                    picture.Image = currentPionBlanc;
                    panelPriseNoir.Controls.Add(picture);
                   
                    
                }
                else 
                {
                    
                    PictureBox picture = new PictureBox();
                    picture.Location = new Point(80 + posX, posY);
                    picture.Size = new Size(75, 75);
                    picture.Image = currentPionBlanc;
                    panelPriseNoir.Controls.Add(picture);
                    posY += 80;

                }

               
            }

            if (e.PropertyName == "countPiecesNoires")
            {
                if (panelPriseBlanc.Controls.Count % 2 == 0)
                {

                    PictureBox picture = new PictureBox();
                    picture.Location = new Point(posXb, posYb);
                    picture.Size = new Size(75, 75);
                    picture.Image = currentPionNoir; 
                    panelPriseBlanc.Controls.Add(picture);
                 

                }
                else
                {

                    PictureBox picture = new PictureBox();
                    picture.Location = new Point(80 + posXb, posYb);
                    picture.Size = new Size(75, 75);
                    picture.Image = currentPionNoir;
                    panelPriseBlanc.Controls.Add(picture);
                    posYb += 80;

                }
            }

        }

        private void OnMouvementDone(EventArgs e) 
        {

            MouvementDone?.Invoke(this, e);
        
        }

        public void EndGame(object sender, EventArgs e)
        {

            Debug.WriteLine("Piece supprimée !");
            if(damier.CountPiecesBlanches == 0)
            {
                MessageBox.Show("Victoire du joueur 2 !");
            }
            if (damier.CountPiecesNoires == 0)
            {
                MessageBox.Show("Victoire du joueur 1 !");
            }


        }

        private void generateDamier()
        {
            panelPriseBlanc.BackColor = Color.Bisque;
            panelPriseNoir.BackColor = Color.Bisque;

            btnGrid = new BtnCase[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    btnGrid[j, i] = new BtnCase();
                    btnGrid[j, i].Height = 75;
                    btnGrid[j, i].Width = 75;
                    panel1.Controls.Add(btnGrid[j, i]);
                    btnGrid[j, i].Location = new Point(i * 75, j * 75);
                    btnGrid[j, i].position = new Point(j, i);
                    btnGrid[j, i].FlatAppearance.BorderSize = 0;
                    btnGrid[j, i].Click += Grid_Button_Click;

                    if ((i + j) % 2 == 0)
                    {
                        btnGrid[j, i].BackColor = Color.Chocolate;
                    }
                    else
                    {
                        btnGrid[j, i].BackColor = Color.Beige;
                        btnGrid[j, i].Enabled = false;
                    }
                }
            }
        }

        private void blockPieces()
        {
            if (damier.selectedPiece != null && (damier.authorizedMouvement.Count != 0 || damier.positionSauterAutorise.Count != 0))
            {
                foreach (BtnCase pieces in btnGrid)
                {
                    pieces.Enabled = false;
                }
            }
            else
            {
                foreach (BtnCase pieces in btnGrid)
                {
                    pieces.Enabled = true;
                }
            }
        }

        private void refreshDamier()
        {
            foreach (BtnCase btn in btnGrid)
            {
                btn.BackgroundImage = null;
            }

            foreach (Pieces pieces in damier.tab2D)
            {

            if(pieces is Pions) { 
                if (pieces.Currentcolor == Pieces.colorPion.Blanc)
                {
                        btnGrid[pieces.Position.X, pieces.Position.Y].BackgroundImage = currentPionBlanc;
                }
                else if (pieces.Currentcolor == Pieces.colorPion.Noir)
                {
                    btnGrid[pieces.Position.X, pieces.Position.Y].BackgroundImage = currentPionNoir;
                }
            }
            if (pieces is Dame)
            {
                    if (pieces.Currentcolor == Pieces.colorPion.Blanc)
                    {
                        btnGrid[pieces.Position.X, pieces.Position.Y].BackgroundImage = currentDameBlanc;
                    }
                    else if (pieces.Currentcolor == Pieces.colorPion.Noir)
                    {
                        btnGrid[pieces.Position.X, pieces.Position.Y].BackgroundImage = currentDameNoire;
                    }

            } 

            }
        }

        private void PossibleMouvementInRed(BtnCase btn)
        {
            btn.FlatAppearance.BorderSize = 5;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.Red;
        }

        private void ReinitializeBtnBorder()
        {
            foreach (BtnCase btn in btnGrid)
            {
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Red;
            }
        }

        private void SelectionnedPiece(BtnCase btn)
        {
            btn.FlatAppearance.BorderSize = 5;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.Blue;
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            BtnCase btnCase = sender as BtnCase;

            if (damier.selectedPiece == null)
            {

                ReinitializeBtnBorder();


                Point selectPiece = new Point(btnCase.position.X, btnCase.position.Y);


                if (damier.tab2D.PieceExistInPosition(selectPiece))
                {
                    damier.selectPion(selectPiece);
                    
                    SelectionnedPiece(btnGrid[damier.selectedPiece.position.X, damier.selectedPiece.position.Y]);
                    blockPieces();

                    foreach (Point point in damier.authorizedMouvement)
                    {
                        BtnCase selected = btnGrid[point.X, point.Y];
                        PossibleMouvementInRed(selected);
                        selected.Enabled = true;
                    }

                    foreach (PathRemove remove in damier.positionSauterAutorise)
                    {
                        BtnCase selected = btnGrid[remove.CoordonneAfterManger.X, remove.CoordonneAfterManger.Y];
                        PossibleMouvementInRed(selected);
                        selected.Enabled = true;
                    }
                    

                }
              
            }
            else
            {

                damier.aSaute = false;
                
                damier.movePion(btnCase.position);

                refreshDamier();
                ReinitializeBtnBorder();

                if(damier.aSaute && damier.positionSauterAutorise.Count != 0) {
                    SelectionnedPiece(btnGrid[damier.selectedPiece.position.X, damier.selectedPiece.position.Y]);
                    blockPieces();
                    foreach (PathRemove remove in damier.positionSauterAutorise)
                     {
                        BtnCase selected = btnGrid[remove.CoordonneAfterManger.X, remove.CoordonneAfterManger.Y];
                        PossibleMouvementInRed(selected);
                        selected.Enabled = true;

                    }

                }
                else {
                    
                    ReinitializeBtnBorder();
                    damier.selectedPiece = null;
                    blockPieces();
                    OnMouvementDone(e);
                }


            }
        }   
    }
}
  
        
     
   
