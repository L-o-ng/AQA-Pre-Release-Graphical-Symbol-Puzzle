using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Symbol_Puzzle
{
    public partial class PuzzleDisplay : Form
    {
        Puzzle puzzle;
        List<Button> buttons;
        public PuzzleDisplay(Puzzle MyPuzzle) {
            InitializeComponent();
            puzzle = MyPuzzle;
        }

        void UpdateUI() {
            lbl_score.Text = $"Score: {puzzle.Score}";
            lbl_symbolsLeft.Text = $"Symbols Left: {puzzle.SymbolsLeft}";
            for (int i = 0; i < puzzle.Grid.Count; i++) {
                if (buttons != null)
                    buttons[i].Enabled = puzzle.Grid[i].CheckSymbolAllowed(cbx_symbol.Text);
            }
        }

        (int row, int column) GetRowCol(int index) {
            int row = puzzle.GridSize - (index / puzzle.GridSize);
            int column = index % puzzle.GridSize + 1;
            return (row, column);
        }

        private void PuzzleDisplay_Load(object sender, EventArgs e) {
            cbx_symbol.SelectedIndex = 0;
            tlp_puzzle.ColumnCount = puzzle.GridSize;
            tlp_puzzle.RowCount = puzzle.GridSize;

            tlp_puzzle.Width = puzzle.GridSize * 50;
            tlp_puzzle.Height = puzzle.GridSize * 50;
            Width = puzzle.GridSize * 50 + 40;
            Height = puzzle.GridSize * 50 + 10 + 85;

            for (int i = 0; i < puzzle.GridSize; i++) {
                tlp_puzzle.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
                tlp_puzzle.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            }

            buttons = new();
            int index = 0;
            for (int i = 0; i < puzzle.GridSize; i++) {
                for (int j = 0; j < puzzle.GridSize; j++) {
                    buttons.Add(new Button() {
                        Text = puzzle.Grid[index].GetSymbol(),
                        Enabled = !(puzzle.Grid[index].GetSymbol() == "@"),
                        Name = Convert.ToString(index)
                    });
                    buttons[index].Click += new EventHandler(b_Click);
                    tlp_puzzle.Controls.Add(buttons[index++]);
                }
            }

            UpdateUI();
        }

        void b_Click(object sender, EventArgs e) {
            puzzle.SymbolsLeft--;
            int index = int.Parse(((Button)sender).Name);
            Cell currentCell = puzzle.Grid[index];

            currentCell.ChangeSymbolInCell(cbx_symbol.Text);
            buttons[index].Text = cbx_symbol.Text;

            (int Row, int Column) = GetRowCol(index);
            int AmountToAddToScore = puzzle.CheckForMatchWithPattern(Row, Column);
            if (AmountToAddToScore > 0) {
                puzzle.Score += AmountToAddToScore;
            }

            if (puzzle.SymbolsLeft == 0) {
                MessageBox.Show($"You scored: {puzzle.Score}");
                Close();
            }

            UpdateUI();
        }

        private void cbx_symbol_SelectedIndexChanged(object sender, EventArgs e) {
            for (int i = 0; i < puzzle.Grid.Count; i++) {
                if (buttons != null)
                    buttons[i].Enabled = puzzle.Grid[i].CheckSymbolAllowed(cbx_symbol.Text);
            }
        }
    }
}
