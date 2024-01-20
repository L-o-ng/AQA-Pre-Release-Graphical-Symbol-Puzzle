namespace Symbol_Puzzle
{
    partial class SetGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetGame));
            spc_startTypes = new SplitContainer();
            btn_standardGame = new Button();
            lbl_standardGame = new Label();
            btn_loadGame = new Button();
            txb_puzzleName = new TextBox();
            lbl_loadGame = new Label();
            ((System.ComponentModel.ISupportInitialize)spc_startTypes).BeginInit();
            spc_startTypes.Panel1.SuspendLayout();
            spc_startTypes.Panel2.SuspendLayout();
            spc_startTypes.SuspendLayout();
            SuspendLayout();
            // 
            // spc_startTypes
            // 
            spc_startTypes.Dock = DockStyle.Fill;
            spc_startTypes.Location = new Point(0, 0);
            spc_startTypes.Name = "spc_startTypes";
            // 
            // spc_startTypes.Panel1
            // 
            spc_startTypes.Panel1.Controls.Add(btn_standardGame);
            spc_startTypes.Panel1.Controls.Add(lbl_standardGame);
            // 
            // spc_startTypes.Panel2
            // 
            spc_startTypes.Panel2.Controls.Add(btn_loadGame);
            spc_startTypes.Panel2.Controls.Add(txb_puzzleName);
            spc_startTypes.Panel2.Controls.Add(lbl_loadGame);
            spc_startTypes.Size = new Size(310, 114);
            spc_startTypes.SplitterDistance = 149;
            spc_startTypes.TabIndex = 0;
            // 
            // btn_standardGame
            // 
            btn_standardGame.Location = new Point(12, 48);
            btn_standardGame.Name = "btn_standardGame";
            btn_standardGame.Size = new Size(125, 52);
            btn_standardGame.TabIndex = 1;
            btn_standardGame.Text = "Start Standard Puzzle";
            btn_standardGame.UseVisualStyleBackColor = true;
            btn_standardGame.Click += btn_standardGame_Click;
            // 
            // lbl_standardGame
            // 
            lbl_standardGame.AutoSize = true;
            lbl_standardGame.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_standardGame.Location = new Point(12, 9);
            lbl_standardGame.Name = "lbl_standardGame";
            lbl_standardGame.Size = new Size(125, 36);
            lbl_standardGame.TabIndex = 0;
            lbl_standardGame.Text = "Standard";
            // 
            // btn_loadGame
            // 
            btn_loadGame.Location = new Point(13, 77);
            btn_loadGame.Name = "btn_loadGame";
            btn_loadGame.Size = new Size(132, 23);
            btn_loadGame.TabIndex = 3;
            btn_loadGame.Text = "Load Puzzle";
            btn_loadGame.UseVisualStyleBackColor = true;
            btn_loadGame.Click += btn_loadGame_Click;
            // 
            // txb_puzzleName
            // 
            txb_puzzleName.Location = new Point(13, 48);
            txb_puzzleName.Name = "txb_puzzleName";
            txb_puzzleName.PlaceholderText = "Enter file name to load";
            txb_puzzleName.Size = new Size(132, 23);
            txb_puzzleName.TabIndex = 2;
            // 
            // lbl_loadGame
            // 
            lbl_loadGame.AutoSize = true;
            lbl_loadGame.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_loadGame.Location = new Point(40, 9);
            lbl_loadGame.Name = "lbl_loadGame";
            lbl_loadGame.Size = new Size(73, 36);
            lbl_loadGame.TabIndex = 1;
            lbl_loadGame.Text = "Load";
            // 
            // SetGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 114);
            Controls.Add(spc_startTypes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SetGame";
            Text = "Start Game";
            Load += SetGame_Load;
            spc_startTypes.Panel1.ResumeLayout(false);
            spc_startTypes.Panel1.PerformLayout();
            spc_startTypes.Panel2.ResumeLayout(false);
            spc_startTypes.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spc_startTypes).EndInit();
            spc_startTypes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer spc_startTypes;
        private Label lbl_standardGame;
        private Label lbl_loadGame;
        private Button btn_standardGame;
        private Button btn_loadGame;
        private TextBox txb_puzzleName;
    }
}
