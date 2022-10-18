namespace Factory;

partial class PopupForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.Return = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.TypeHolder = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.Return.Location = new System.Drawing.Point(41, 151);
            this.Return.Name = "button1";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 0;
            this.Return.Text = "button1";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // button2
            // 
            this.Add.Location = new System.Drawing.Point(181, 151);
            this.Add.Name = "button2";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "button2";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(98, 17);
            this.Description.Name = "label1";
            this.Description.Size = new System.Drawing.Size(38, 15);
            this.Description.TabIndex = 2;
            this.Description.Text = "label1";
            // 
            // comboBox1
            // 
            this.TypeHolder.FormattingEnabled = true;
            this.TypeHolder.Location = new System.Drawing.Point(79, 52);
            this.TypeHolder.Name = "comboBox1";
            this.TypeHolder.Size = new System.Drawing.Size(121, 23);
            this.TypeHolder.TabIndex = 3;
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 242);
            this.Controls.Add(this.TypeHolder);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Return);
            this.Name = "PopupForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button Return;
    private Button Add;
    private Label Description;
    private ComboBox TypeHolder;
}