namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // Game state variables
        private string currentPlayer = "X"; // Tracks the current player ("X" or "O")
        private bool gameActive = true; // Checks if the game is still active
        private string[] board = new string[9]; // Array to store the board state

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = int.Parse(btn.Tag.ToString());

            if (board[index] == null && gameActive)
            {
                btn.Text = currentPlayer;
                board[index] = currentPlayer;

                CheckWinner(); // After each move, check for a winner
                currentPlayer = (currentPlayer == "X") ? "O" : "X"; // Switch players
            }
        }

        private void CheckWinner()
        {
            string[,] winPatterns = new string[,]
            {
        { board[0], board[1], board[2] },
        { board[3], board[4], board[5] },
        { board[6], board[7], board[8] },
        { board[0], board[3], board[6] },
        { board[1], board[4], board[7] },
        { board[2], board[5], board[8] },
        { board[0], board[4], board[8] },
        { board[2], board[4], board[6] }
            };

            for (int i = 0; i < 8; i++)
            {
                if (winPatterns[i, 0] != null && winPatterns[i, 0] == winPatterns[i, 1] && winPatterns[i, 0] == winPatterns[i, 2])
                {
                    gameActive = false;
                    MessageBox.Show($"{winPatterns[i, 0]} Wins!");
                    return;
                }
            }

            // Check for a draw
            if (!board.Contains(null))
            {
                MessageBox.Show("It's a draw!");
                gameActive = false;
            }
        }

        private void resetGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = null;
            }

            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Tag != null)
                {
                    ((Button)c).Text = "";
                }
            }

            currentPlayer = "X";
            gameActive = true;
        }

    }
}