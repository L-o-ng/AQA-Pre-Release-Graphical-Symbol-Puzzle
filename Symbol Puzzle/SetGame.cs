namespace Symbol_Puzzle
{
    public partial class SetGame : Form
    {
        Puzzle MyPuzzle;
        public SetGame() {
            InitializeComponent();
        }

        private void SetGame_Load(object sender, EventArgs e) {
            
        }

        private void btn_standardGame_Click(object sender, EventArgs e) {
            MyPuzzle = new Puzzle(8, Convert.ToInt32(8 * 8 * 0.6));
            PuzzleDisplay puzzleDisplay = new(MyPuzzle);
            puzzleDisplay.ShowDialog();
        }

        private void btn_loadGame_Click(object sender, EventArgs e) {
            MyPuzzle = new Puzzle(txb_puzzleName.Text + ".txt");
            if (MyPuzzle.loadSuccess) {
                PuzzleDisplay puzzleDisplay = new(MyPuzzle);
                puzzleDisplay.ShowDialog();
            }
        }
    }
}
