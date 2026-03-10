using System.Diagnostics;
namespace Scacchi
{
    public partial class Scacchi : Form
    {
        private Panel[][] Scacchiera;
        private int cont = 0;
        private int Mosse = 0;
        private PictureBox PedoneBianco = null, PedoneNero = null;
        public Scacchi()
        {
            InitializeComponent();
            Scacchiera = new Panel[8][];
        }

        private void Scacchi_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Scacchiera.Length; i++)
            {
                Scacchiera[i] = new Panel[Scacchiera.Length];
                for (int j = 0; j < Scacchiera.Length; j++)
                {
                    Scacchiera[i][j] = new Panel();
                    this.Controls.Add(Scacchiera[i][j]);
                    Scacchiera[i][j].Tag = cont;
                    Scacchiera[i][j].Name = "Casella " + i + ";" + j;
                    Scacchiera[i][j].Size = new Size(90, 90);
                    Scacchiera[i][j].Location = new Point(600 + 90 * j, 125 + 90 * i);
                    Scacchiera[i][j].BorderStyle = BorderStyle.FixedSingle;
                    Scacchiera[i][j].Click += MovimentoPedoniBianchi_Click;
                    Scacchiera[i][j].Click += MovimentoPedoniNeri_Click;
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                            Scacchiera[i][j].BackColor = Color.SandyBrown;
                        else
                            Scacchiera[i][j].BackColor = Color.RosyBrown;
                    }
                    else
                    {
                        if (j % 2 != 0)
                            Scacchiera[i][j].BackColor = Color.SandyBrown;
                        else
                            Scacchiera[i][j].BackColor = Color.RosyBrown;
                    }
                    if (i == 0)
                    {
                        switch (j)
                        {
                            case 0:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_TorreNera1);
                                Img_TorreNera1.Location = new Point(0, 0);
                                Img_TorreNera1.BackColor = Color.Transparent;
                                Img_TorreNera1.Tag = cont;
                                break;
                            case 1:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_CavalloNero1);
                                Img_CavalloNero1.Location = new Point(0, 0);
                                Img_CavalloNero1.BackColor = Color.Transparent;
                                Img_CavalloNero1.Tag = cont;
                                break;
                            case 2:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_AlfiereNero1);
                                Img_AlfiereNero1.Location = new Point(0, 0);
                                Img_AlfiereNero1.BackColor = Color.Transparent;
                                Img_AlfiereNero1.Tag = cont;
                                break;
                            case 3:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_ReginaNera);
                                Img_ReginaNera.Location = new Point(0, 0);
                                Img_ReginaNera.BackColor = Color.Transparent;
                                Img_ReginaNera.Tag = cont;
                                break;
                            case 4:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_ReNero);
                                Img_ReNero.Location = new Point(0, 0);
                                Img_ReNero.BackColor = Color.Transparent;
                                Img_ReNero.Tag = cont;
                                break;
                            case 5:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_AlfiereNero2);
                                Img_AlfiereNero2.Location = new Point(0, 0);
                                Img_AlfiereNero2.BackColor = Color.Transparent;
                                Img_AlfiereNero2.Tag = cont;
                                break;
                            case 6:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_CavalloNero2);
                                Img_CavalloNero2.Location = new Point(0, 0);
                                Img_CavalloNero2.BackColor = Color.Transparent;
                                Img_CavalloNero2.Tag = cont;
                                break;
                            case 7:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_TorreNera2);
                                Img_TorreNera2.Location = new Point(0, 0);
                                Img_TorreNera2.BackColor = Color.Transparent;
                                Img_TorreNera2.Tag = cont;
                                break;
                            default:
                                Debug.WriteLine("Errore nella generazione del codice!");
                                Application.Exit();
                                break;
                        }
                    }
                    else if (i == 1)
                    {
                        switch (j)
                        {
                            case 0:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneNero1);
                                Img_PedoneNero1.Location = new Point(0, 0);
                                Img_PedoneNero1.BackColor = Color.Transparent;
                                Img_PedoneNero1.Tag = cont;
                                Img_PedoneNero1.Click += MovimentoPedoniNeri_Click;
                                break;
                            case 1:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneNero2);
                                Img_PedoneNero2.Location = new Point(0, 0);
                                Img_PedoneNero2.BackColor = Color.Transparent;
                                Img_PedoneNero2.Tag = cont;
                                Img_PedoneNero2.Click += MovimentoPedoniNeri_Click;
                                break;
                            case 2:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneNero3);
                                Img_PedoneNero3.Location = new Point(0, 0);
                                Img_PedoneNero3.BackColor = Color.Transparent;
                                Img_PedoneNero3.Tag = cont;
                                Img_PedoneNero3.Click += MovimentoPedoniNeri_Click;
                                break;
                            case 3:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneNero4);
                                Img_PedoneNero4.Location = new Point(0, 0);
                                Img_PedoneNero4.BackColor = Color.Transparent;
                                Img_PedoneNero4.Tag = cont;
                                Img_PedoneNero4.Click += MovimentoPedoniNeri_Click;
                                break;
                            case 4:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneNero5);
                                Img_PedoneNero5.Location = new Point(0, 0);
                                Img_PedoneNero5.BackColor = Color.Transparent;
                                Img_PedoneNero5.Tag = cont;
                                Img_PedoneNero5.Click += MovimentoPedoniNeri_Click;
                                break;
                            case 5:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneNero6);
                                Img_PedoneNero6.Location = new Point(0, 0);
                                Img_PedoneNero6.BackColor = Color.Transparent;
                                Img_PedoneNero6.Tag = cont;
                                Img_PedoneNero6.Click += MovimentoPedoniNeri_Click;
                                break;
                            case 6:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneNero7);
                                Img_PedoneNero7.Location = new Point(0, 0);
                                Img_PedoneNero7.BackColor = Color.Transparent;
                                Img_PedoneNero7.Tag = cont;
                                Img_PedoneNero7.Click += MovimentoPedoniNeri_Click;
                                break;
                            case 7:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneNero8);
                                Img_PedoneNero8.Location = new Point(0, 0);
                                Img_PedoneNero8.BackColor = Color.Transparent;
                                Img_PedoneNero8.Tag = cont;
                                Img_PedoneNero8.Click += MovimentoPedoniNeri_Click;
                                break;
                            default:
                                Debug.WriteLine("Errore nella generazione del codice!");
                                Application.Exit();
                                break;
                        }
                    }
                    else if (i == 6)
                    {
                        switch (j)
                        {
                            case 0:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneBianco1);
                                Img_PedoneBianco1.Location = new Point(0, 0);
                                Img_PedoneBianco1.BackColor = Color.Transparent;
                                Img_PedoneBianco1.Tag = cont;
                                Img_PedoneBianco1.Click += MovimentoPedoniBianchi_Click;
                                break;
                            case 1:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneBianco2);
                                Img_PedoneBianco2.Location = new Point(0, 0);
                                Img_PedoneBianco2.BackColor = Color.Transparent;
                                Img_PedoneBianco2.Tag = cont;
                                Img_PedoneBianco2.Click += MovimentoPedoniBianchi_Click;
                                break;
                            case 2:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneBianco3);
                                Img_PedoneBianco3.Location = new Point(0, 0);
                                Img_PedoneBianco3.BackColor = Color.Transparent;
                                Img_PedoneBianco3.Tag = cont;
                                Img_PedoneBianco3.Click += MovimentoPedoniBianchi_Click;
                                break;
                            case 3:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneBianco4);
                                Img_PedoneBianco4.Location = new Point(0, 0);
                                Img_PedoneBianco4.BackColor = Color.Transparent;
                                Img_PedoneBianco4.Tag = cont;
                                Img_PedoneBianco4.Click += MovimentoPedoniBianchi_Click;
                                break;
                            case 4:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneBianco5);
                                Img_PedoneBianco5.Location = new Point(0, 0);
                                Img_PedoneBianco5.BackColor = Color.Transparent;
                                Img_PedoneBianco5.Tag = cont;
                                Img_PedoneBianco5.Click += MovimentoPedoniBianchi_Click;
                                break;
                            case 5:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneBianco6);
                                Img_PedoneBianco6.Location = new Point(0, 0);
                                Img_PedoneBianco6.BackColor = Color.Transparent;
                                Img_PedoneBianco6.Tag = cont;
                                Img_PedoneBianco6.Click += MovimentoPedoniBianchi_Click;
                                break;
                            case 6:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneBianco7);
                                Img_PedoneBianco7.Location = new Point(0, 0);
                                Img_PedoneBianco7.BackColor = Color.Transparent;
                                Img_PedoneBianco7.Tag = cont;
                                Img_PedoneBianco7.Click += MovimentoPedoniBianchi_Click;
                                break;
                            case 7:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_PedoneBianco8);
                                Img_PedoneBianco8.Location = new Point(0, 0);
                                Img_PedoneBianco8.BackColor = Color.Transparent;
                                Img_PedoneBianco8.Tag = cont;
                                Img_PedoneBianco8.Click += MovimentoPedoniBianchi_Click;
                                break;
                            default:
                                Debug.WriteLine("Errore nella generazione del codice!");
                                Application.Exit();
                                break;
                        }
                    }
                    else if (i == 7)
                    {
                        switch (j)
                        {
                            case 0:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_TorreBianca1);
                                Img_TorreBianca1.Location = new Point(0, 0);
                                Img_TorreBianca1.BackColor = Color.Transparent;
                                Img_TorreBianca1.Tag = cont;
                                break;
                            case 1:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_CavalloBianco1);
                                Img_CavalloBianco1.Location = new Point(0, 0);
                                Img_CavalloBianco1.BackColor = Color.Transparent;
                                Img_CavalloBianco1.Tag = cont;
                                break;
                            case 2:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_AlfiereBianco1);
                                Img_AlfiereBianco1.Location = new Point(0, 0);
                                Img_AlfiereBianco1.BackColor = Color.Transparent;
                                Img_AlfiereBianco1.Tag = cont;
                                break;
                            case 3:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_ReginaBianca);
                                Img_ReginaBianca.Location = new Point(0, 0);
                                Img_ReginaBianca.BackColor = Color.Transparent;
                                Img_ReginaBianca.Tag = cont;
                                break;
                            case 4:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_ReBianco);
                                Img_ReBianco.Location = new Point(0, 0);
                                Img_ReBianco.BackColor = Color.Transparent;
                                Img_ReBianco.Tag = cont;
                                break;
                            case 5:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_AlfiereBianco2);
                                Img_AlfiereBianco2.Location = new Point(0, 0);
                                Img_AlfiereBianco2.BackColor = Color.Transparent;
                                Img_AlfiereBianco2.Tag = cont;
                                break;
                            case 6:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_CavalloBianco2);
                                Img_CavalloBianco2.Location = new Point(0, 0);
                                Img_CavalloBianco2.BackColor = Color.Transparent;
                                Img_CavalloBianco2.Tag = cont;
                                break;
                            case 7:
                                Debug.WriteLine("L'immagine è stata aggiunta nelle coordinate: " + i + ";" + j);
                                Scacchiera[i][j].Controls.Add(Img_TorreBianca2);
                                Img_TorreBianca2.Location = new Point(0, 0);
                                Img_TorreBianca2.BackColor = Color.Transparent;
                                Img_TorreBianca2.Tag = cont;
                                break;
                            default:
                                Debug.WriteLine("Errore nella generazione del codice!");
                                Application.Exit();
                                break;
                        }
                    }
                    cont++;
                }
            }
        }
        public void MovimentoPedoniBianchi_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PedoneBianco = (PictureBox)sender;
                Debug.WriteLine("Pedina selezionata: " + PedoneBianco.Name + " con indice: " + (int)PedoneBianco.Tag);
            }
            else if (sender is Panel && PedoneBianco != null)
            {
                Panel CasellaDestinazione = (Panel)sender;
                Debug.WriteLine("Tentativo di muovere in casella: " + (int)CasellaDestinazione.Tag);
                if ((int)CasellaDestinazione.Tag == (int)PedoneBianco.Tag - 8)
                {
                    Panel CasellaCorrente = (Panel)PedoneBianco.Parent;
                    CasellaCorrente.Controls.Remove(PedoneBianco);
                    CasellaDestinazione.Controls.Add(PedoneBianco);
                    PedoneBianco.Tag = CasellaDestinazione.Tag;
                    PedoneBianco.Location = new Point(0, 0);
                    Debug.WriteLine("Pedina mossa!");
                }
                else
                {
                    Debug.WriteLine("Il giocatore ha tentato una mossa non valida!");
                }
                PedoneBianco = null;
            }
            }
        public void MovimentoPedoniNeri_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PedoneNero = (PictureBox)sender;
                Debug.WriteLine("Pedina selezionata: " + PedoneNero.Name + " con indice: " + (int)PedoneNero.Tag);
            }
            else if (sender is Panel && PedoneNero != null)
            {
                Panel CasellaDestinazione = (Panel)sender;
                Debug.WriteLine("Tentativo di muovere in casella: " + (int)CasellaDestinazione.Tag);
                if ((int)CasellaDestinazione.Tag == (int)PedoneNero.Tag + 8)
                {
                    Panel CasellaCorrente = (Panel)PedoneNero.Parent;
                    CasellaCorrente.Controls.Remove(PedoneNero);
                    CasellaDestinazione.Controls.Add(PedoneNero);
                    PedoneNero.Tag = CasellaDestinazione.Tag;
                    PedoneNero.Location = new Point(0, 0);
                    Debug.WriteLine("Pedina mossa!");
                } 
                else
                {
                    Debug.WriteLine("Il giocatore ha tentato una mossa non valida!");
                }
            }

            PedoneNero = null;
        }
    }
}