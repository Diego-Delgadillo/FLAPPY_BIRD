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
            scoreText.Text = "Puntuación: " + Convert.ToString(score);


            //estas sentencias hacen que los pipes cambien de posiscion generando la ilusion de movimiento
            if(pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;//aumenta el puntaje
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;//aumenta el valor del puntaje
            }

            if (flappyByrd.Bounds.IntersectsWith(pipeBottom.Bounds) ||//intersecta con la tuberia del fondo 
                flappyByrd.Bounds.IntersectsWith(pipeTop.Bounds) || //intersecta con la tuberia superior
                flappyByrd.Bounds.IntersectsWith(ground.Bounds)) //intersecta con la parte inferior
            {
                endGame();//llamamos a la funcion que termina el juego
            }



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

        private void endGame() //metodo para que termine el juego
        {
            gameTimer.Stop();
            scoreText.Text += "  Game over!";
        }

    }
}
