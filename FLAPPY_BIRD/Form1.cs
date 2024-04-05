namespace FLAPPY_BIRD
{
    public partial class Form1 : Form
    {
    //declaramos las variables que utilizaremos

    int pipeSpeed = 8;
    int gravity = 5;
    int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyByrd.Top += gravity;//se desplaza hacia arriaba de acuerdo a la gravedad
            //hace que se desplaze hacia la izquierda los "pipes" o tuberias
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;



        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {   
                gravity = -5; //cambia a -5 el valor de la gravedad
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;//devuelve el valor que tenía la gravedad
            }
        }
    }
}
