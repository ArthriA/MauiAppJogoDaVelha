namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X"; // COMEÇA COM X
        int jogadas = 0; // CONTA AS JOGADAS

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender; // CRIA BOTÃO

            btn.IsEnabled = false; // DESATIVA UM  BOTÃO PREENChIDO
            btn.Text = vez; // DEFINE O TEXTO DO BOTÃO (X ou O)

            jogadas++; // INCREMENTA UM CONTADOR DE JOGADAS

            // VERIFICA QUEM VENCEU
            if (
                (btn10.Text == btn11.Text && btn11.Text == btn12.Text && btn10.Text != "") || // Linha 1
                (btn20.Text == btn21.Text && btn21.Text == btn22.Text && btn20.Text != "") || // Linha 2
                (btn30.Text == btn31.Text && btn31.Text == btn32.Text && btn30.Text != "") || // Linha 3
                (btn10.Text == btn20.Text && btn20.Text == btn30.Text && btn10.Text != "") || // Coluna 1
                (btn11.Text == btn21.Text && btn21.Text == btn31.Text && btn11.Text != "") || // Coluna 2
                (btn12.Text == btn22.Text && btn22.Text == btn32.Text && btn12.Text != "") || // Coluna 3
                (btn10.Text == btn21.Text && btn21.Text == btn32.Text && btn10.Text != "") || // Diagonal 1
                (btn12.Text == btn21.Text && btn21.Text == btn30.Text && btn12.Text != "")    // Diagonal 2
            )
            {
                DisplayAlert("Parabéns!", $"{vez} ganhou!", "OK");
                Zerar(); // RESETA O JOGO
                return; // O MÉTODO PARA AQUI
            }

            // VERIFICA SE ACONTECEU EMPATE
            if (jogadas == 9)
            {
                DisplayAlert("Empate!", "Ninguém ganhou!", "OK");
                Zerar(); // RESETA O JOGO
                return; // PARA O MÉTODO AQUI
            }

            // ALTERNA x E o
            vez = (vez == "X") ? "O" : "X";
        }

        private void Zerar()
        {
            // RESETA TODOS OS BOTÕES
            btn10.Text = btn11.Text = btn12.Text = "";
            btn20.Text = btn21.Text = btn22.Text = "";
            btn30.Text = btn31.Text = btn32.Text = "";

            // ATIVA TODOS OS BOTÕES
            btn10.IsEnabled = btn11.IsEnabled = btn12.IsEnabled = true;
            btn20.IsEnabled = btn21.IsEnabled = btn22.IsEnabled = true;
            btn30.IsEnabled = btn31.IsEnabled = btn32.IsEnabled = true;

            // RESETA AS VARIÁVEIS
            vez = "X"; // Começa com X
            jogadas = 0; // Zera as jogadas
        }
    }
}
