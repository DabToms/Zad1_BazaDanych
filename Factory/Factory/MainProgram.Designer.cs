namespace Factory;

partial class MainProgram
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
            this.AddRow = new System.Windows.Forms.Button();
            this.AddCollumn = new System.Windows.Forms.Button();
            this.DataBox = new System.Windows.Forms.ListBox();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddRow
            // 
            this.AddRow.Location = new System.Drawing.Point(12, 12);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(175, 44);
            this.AddRow.TabIndex = 0;
            this.AddRow.Text = "AddRow";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // AddCollumn
            // 
            this.AddCollumn.Location = new System.Drawing.Point(193, 12);
            this.AddCollumn.Name = "AddCollumn";
            this.AddCollumn.Size = new System.Drawing.Size(175, 44);
            this.AddCollumn.TabIndex = 1;
            this.AddCollumn.Text = "AddCollumn";
            this.AddCollumn.UseVisualStyleBackColor = true;
            this.AddCollumn.Click += new System.EventHandler(this.AddCollumn_Click);
            // 
            // DataBox
            // 
            this.DataBox.FormattingEnabled = true;
            this.DataBox.ItemHeight = 15;
            this.DataBox.Location = new System.Drawing.Point(12, 62);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(537, 229);
            this.DataBox.TabIndex = 2;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(374, 12);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(175, 44);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MainProgram
            // 
            this.ClientSize = new System.Drawing.Size(567, 304);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.AddCollumn);
            this.Controls.Add(this.AddRow);
            this.Name = "MainProgram";
            this.ResumeLayout(false);

    }

    #endregion

    private Button AddRow;
    private Button AddCollumn;
    private ListBox DataBox;
    private Button Clear;
}