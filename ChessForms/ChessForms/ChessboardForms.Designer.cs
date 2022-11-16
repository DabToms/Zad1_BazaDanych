namespace ChessForms;

partial class ChessboardForms
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.Undo = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(65, 261);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(75, 23);
            this.Undo.TabIndex = 0;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Redo
            // 
            this.Redo.Location = new System.Drawing.Point(220, 261);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(75, 23);
            this.Redo.TabIndex = 1;
            this.Redo.Text = "Redo";
            this.Redo.UseVisualStyleBackColor = true;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            this.Redo.Paint += new System.Windows.Forms.PaintEventHandler(this.Redo_Paint);
            // 
            // ChessboardForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.Undo);
            this.Name = "ChessboardForms";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ChessboardForms_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChessboardForms_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChessboardForms_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChessboardForms_MouseUp);
            this.ResumeLayout(false);

    }

    #endregion

    private Button Undo;
    private Button Redo;
}
