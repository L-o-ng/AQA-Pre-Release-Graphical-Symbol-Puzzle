namespace Symbol_Puzzle
{
    partial class PuzzleDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuzzleDisplay));
            cbx_symbol = new ComboBox();
            tlp_puzzle = new TableLayoutPanel();
            lbl_symbolsLeft = new Label();
            lbl_score = new Label();
            SuspendLayout();
            // 
            // cbx_symbol
            // 
            cbx_symbol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_symbol.FormattingEnabled = true;
            cbx_symbol.Items.AddRange(new object[] { "T", "X", "Q" });
            cbx_symbol.Location = new Point(12, 12);
            cbx_symbol.Name = "cbx_symbol";
            cbx_symbol.Size = new Size(121, 23);
            cbx_symbol.TabIndex = 0;
            cbx_symbol.SelectedIndexChanged += cbx_symbol_SelectedIndexChanged;
            // 
            // tlp_puzzle
            // 
            tlp_puzzle.ColumnCount = 2;
            tlp_puzzle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_puzzle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_puzzle.Location = new Point(12, 71);
            tlp_puzzle.Name = "tlp_puzzle";
            tlp_puzzle.RowCount = 2;
            tlp_puzzle.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_puzzle.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_puzzle.Size = new Size(200, 200);
            tlp_puzzle.TabIndex = 1;
            // 
            // lbl_symbolsLeft
            // 
            lbl_symbolsLeft.AutoSize = true;
            lbl_symbolsLeft.Location = new Point(12, 38);
            lbl_symbolsLeft.Name = "lbl_symbolsLeft";
            lbl_symbolsLeft.Size = new Size(78, 15);
            lbl_symbolsLeft.TabIndex = 2;
            lbl_symbolsLeft.Text = "Symbols Left:";
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.Location = new Point(12, 53);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new Size(39, 15);
            lbl_score.TabIndex = 3;
            lbl_score.Text = "Score:";
            // 
            // PuzzleDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 281);
            Controls.Add(lbl_score);
            Controls.Add(lbl_symbolsLeft);
            Controls.Add(tlp_puzzle);
            Controls.Add(cbx_symbol);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PuzzleDisplay";
            Text = "Puzzle";
            Load += PuzzleDisplay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_symbol;
        private TableLayoutPanel tlp_puzzle;
        private Label lbl_symbolsLeft;
        private Label lbl_score;
    }
}